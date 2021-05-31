using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Server.Queries.Products;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.ComponentModels.Products;
using RektaManagerApp.Shared.ComponentModels.Suppliers;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;
        private readonly IProductRepository _repo;

        public ProductsController(RektaManagerAppContext context, IProductRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductComponentModel>>> GetProducts([FromQuery] ProductQuery query)
        {
            var result = await _repo.Get(query);
            return Ok(result);
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<ActionResult<ProductComponentModel>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.ProductInventory)
                .Include(c => c.ProductCategories)
                .Where(p => p.Id == id)
                .Select(p => new ProductComponentModel
                {
                    CostPrice = p.CostPrice,
                    Name = p.Name,
                    InventoryName = p.ProductInventory.Name,
                    ProductId = p.Id,
                    Description = p.Description,
                    ProductInventoryId = p.ProductInventoryId,
                    SupplierId = p.SupplierId,
                    ProductUniqueIdentifier = p.ProductUniqueIdentifier,
                    QuantityBought = p.QuantityBought,
                    UnitMeasure = p.UnitMeasure,
                }).SingleOrDefaultAsync().ConfigureAwait(false);

            if (product == null)
            {
                return NotFound();
            }

            product.TotalCostPrice = product.CostPrice * (decimal)product.QuantityBought;

            return Ok(product);
        }

        [HttpGet("supplierselect", Name = "GetSupplierForProductPost")]
        public async Task<ActionResult<SupplierSelectModel>> GetSuppliers()
        {
            var result = await _context.Suppliers.AsNoTracking()
                .Select(s => new SupplierSelectModel
                {
                    SupplierId = s.Id,
                    SupplierName = s.Name
                }).ToListAsync();
            return Ok(result);
        }

        //[HttpGet("orderItemsList", Name = "GetOrderItems")]
        //public async Task<ActionResult<OrderItem>> GetOrderItems()
        //{
        //    var result = await _context.OrderItems.AsNoTracking().ToListAsync().ConfigureAwait(false);
        //    return Ok(result);
        //}

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, [FromBody]ProductUpsertComponentModel product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            await _repo.Update(product);

            var modified = _context.ChangeTracker.Entries<Product>()
                .Where(x => x.State == EntityState.Modified)
                .SingleOrDefault();

            var inventory = await _context.Inventories.SingleOrDefaultAsync(i => i.Products.First().Id == id)
                .ConfigureAwait(false);

            var dbVal = await modified.GetDatabaseValuesAsync();
            var fromDb = dbVal.ToObject() as Product;

            var changes = new PropertyChanges<Product>(modified, fromDb);

            var auditTrack = new ProductActionsAudit
            {
                Actions = ActionPerformed.Updated,
                Changes = JsonSerializer.Serialize(changes),
            };


            try
            {
                await _repo.Save<Product>();
                await _repo.Save<ProductActionsAudit>();
                return RedirectToRoute("GetProductById", new { id = product.Id });
            }
            catch (DbUpdateConcurrencyException e)
            {
                await e.Entries.Single().ReloadAsync();
                await _repo.Save<Product>();
                return Ok();

            }
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct([FromBody] ProductUpsertComponentModel model)
        {
            var newId = 0;
            try
            {
                var product = new Product
                {
                    Name = model.Name.ToUpper(),
                    Description = model.Description.ToUpper(),
                    ProductUniqueIdentifier = model.ProductUniqueIdentifier,
                    QuantityBought = model.QuantityBought,
                    ProductInventoryId = model.ProductInventoryId,
                    CostPrice = model.CostPrice,
                    SupplierId = model.SupplierId,
                    UnitMeasure = model.UnitMeasure
                };
                if (ModelState.IsValid)
                {
                    //_context.Products.Add(product);
                    await _repo.Add(product);
                    await _repo.Save<Product>();
                    var result = await _context.Products
                        .Where(x => x.ProductUniqueIdentifier.Equals(model.ProductUniqueIdentifier))
                        .SingleOrDefaultAsync().ConfigureAwait(false);
                    newId = result.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(new { e.Message});
            }

            
            return CreatedAtAction("GetProduct", new { id = newId }, new {});
        }

        [HttpPost("orderItem", Name = "CreateOrderItem")]
        public async Task<ActionResult<OrderItem>> PostOrderItem([FromBody] OrderItem model)
        {
            if(!ModelState.IsValid && await _context.OrderItems.AnyAsync(x => x.ItemName.Contains(model.ItemName)))
            {
                return BadRequest(new { ErrorMessage = "Your payload was in a bad state or a case of duplication!" });
            }

            _context.OrderItems.Add(model);
            await _repo.Save<OrderItem>();

            return CreatedAtAction("GetOrderItems","Orders",null,new { });
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        private async Task<IEnumerable<Product>> ReturnProducts(int skip, int take)
        {
            return await _context.Products.AsNoTracking()
                .Include(p => p.ProductInventory)
                .Include(p => p.ProductCategories)
                .Skip(skip)
                .Take(take)
                .OrderBy(p => p.Name)
                .ToArrayAsync();
        }
    }
}
