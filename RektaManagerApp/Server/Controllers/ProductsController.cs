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
using RektaManagerApp.Shared.Abstractions;
using RektaManagerApp.Shared.ComponentModels.Orders;
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
        public async Task<IActionResult> PutProduct(int id, [FromBody] ProductUpsertComponentModel product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            var target = await _context.Products.FindAsync(product.Id).ConfigureAwait(false);
            target.Id = product.Id;
            target.CostPrice = product.CostPrice;
            target.QuantityBought = product.QuantityBought;
            target.Name = product.Name;
            target.Timestamp = product.Timestamp;
            target.ProductInventory = new Inventory { Id = product.ProductInventoryId };
            target.ProductUniqueIdentifier = product.ProductUniqueIdentifier;
            target.UnitMeasure = product.UnitMeasure;
            target.ProductInventoryId = product.ProductInventoryId;
            target.Description = product.Description;

            var product1 = new Product
            {
                Id = product.Id,
                CostPrice = product.CostPrice,
                QuantityBought = product.QuantityBought,
                Name = product.Name,
                Timestamp = product.Timestamp,
                ProductInventory = new Inventory { Id = product.ProductInventoryId },
                ProductUniqueIdentifier = product.ProductUniqueIdentifier,
                UnitMeasure = product.UnitMeasure,
                ProductInventoryId = product.ProductInventoryId,
                Description = product.Description
            };
            _context.Entry(target).State = EntityState.Modified;
            var audit = new ProductActionsAudit();

            try
            {
                await _repo.Update<Product>(product1, target, audit);
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
            if (!ModelState.IsValid)
                return BadRequest();
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
                    await _repo.Add(product).ConfigureAwait(false);
                    await _repo.Save<Product>().ConfigureAwait(false);

                    var changes = JsonSerializer.Serialize(product);
                    //add notification
                    var audit = new ProductActionsAudit
                    {
                        Actions = ActionPerformed.Created,
                        Changes = changes
                    };
                    await _repo.Add(audit).ConfigureAwait(false);
                    await _repo.Save<ProductActionsAudit>().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(new { e.Message });
            }


            return CreatedAtAction("GetProduct", new { id = newId }, new { });
        }

        [HttpPost("orderItem", Name = "CreateOrderItem")]
        public async Task<ActionResult<OrderItem>> PostOrderItem([FromBody] OrderItem model)
        {
            if (!ModelState.IsValid && await _context.OrderItems.AnyAsync(x => x.ItemName.Contains(model.ItemName)))
            {
                return BadRequest(new { ErrorMessage = "Your payload was in a bad state or a case of duplication!" });
            }

            _context.OrderItems.Add(model);
            await _repo.Save<OrderItem>();

            return CreatedAtAction("GetOrderItems", "Orders", null, new { });
        }

        [HttpPut("orderItem", Name = "UpdateOrderItem")]
        public async Task<ActionResult<OrderItemComponentModel>> PutOrderItem(int id, [FromBody] OrderItem model)
        {
            var targetOrder = await _context.OrderItems.FindAsync(id).ConfigureAwait(false);
            targetOrder.Id = model.Id;
            targetOrder.ImageUrl = model.ImageUrl;
            targetOrder.ItemCode = model.ItemCode;
            targetOrder.ItemName = model.ItemName;
            targetOrder.Price = model.Price;
            targetOrder.Timestamp = model.Timestamp;
            _context.Entry(targetOrder).State = EntityState.Modified;
            var audit = new OrderItemActionsAudit();
            try
            {
                await _repo.Update<OrderItem>(model, targetOrder, audit);
                await _repo.Save<OrderItem>();
                await _repo.Save<OrderItemActionsAudit>();
            }
            catch (DbUpdateConcurrencyException e)
            {

                await e.Entries.Single().ReloadAsync();
                await _repo.Save<Product>();
                return Ok();
            }
            return Ok();
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

            //_context.Products.Remove(product);
            await _repo.Delete<Product>(id).ConfigureAwait(false);
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
