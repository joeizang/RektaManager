using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManager.Server.Data;
using RektaManager.Server.Queries.Products;
using RektaManager.Shared;
using RektaManager.Shared.ComponentModels.Inventories;
using RektaManager.Shared.ComponentModels.Products;

namespace RektaManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly RektaManagerContext _context;

        public ProductsController(RektaManagerContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductComponentModel>>> GetProducts([FromQuery] ProductQuery query)
        {
            if (query.Skip == 0 && query.Take == 0)
            {
                return Ok(await ReturnProducts(0, 10));
            }
            else
            {
                return (Ok(await ReturnProducts(query.Skip, query.Take)));
            }
            
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailComponentModel>> GetProduct(int id)
        {
            var product = await _context.Products.AsNoTracking()
                .Include(p => p.ProductInventory)
                .Where(p => p.Id == id)
                .Select(p => new ProductDetailComponentModel()
                {
                    CostPrice = p.CostPrice,
                    Name = p.Name,
                    Description = p.Description,
                    InventoryName = p.ProductInventory.Name,
                    ProductId = p.Id,
                    ProductUniqueIdentifier = p.ProductUniqueIdentifier,
                    QuantityBought = p.QuantityBought,
                    UnitMeasure = p.UnitMeasure
                }).SingleOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, [FromBody]ProductUpsertComponentModel product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            var uuidTest = _context.Products.AsNoTracking()
                .Any(x => x.ProductUniqueIdentifier.Equals(product.ProductUniqueIdentifier));

            var target = new Product()
            {
                Name = product.Name,
                CostPrice = product.CostPrice,
                Description = product.Description,
                QuantityBought = product.QuantityBought,
                UnitMeasure = product.UnitMeasure,
                ProductInventory = new Inventory() {Id = product.ProductInventoryId},
                UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
            };

            if (uuidTest)
                target.ProductUniqueIdentifier = product.ProductUniqueIdentifier;

            _context.Entry(target).State = EntityState.Modified;

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
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

        private async Task<IEnumerable<ProductComponentModel>> ReturnProducts(int skip, int take)
        {
            return await _context.Products.AsNoTracking()
                .Include(p => p.ProductInventory)
                .Select(x => new ProductComponentModel()
                {
                    CostPrice = x.CostPrice,
                    Description = x.Description,
                    Name = x.Name,
                    ProductId = x.Id,
                    ProductInventoryId = x.ProductInventoryId,
                    InventoryName = x.ProductInventory.Name,
                    QuantityBought = x.QuantityBought,
                    ProductUniqueIdentifier = x.ProductUniqueIdentifier,
                    UnitMeasure = x.UnitMeasure
                })
                .Skip(skip)
                .Take(take)
                .ToArrayAsync();
        }
    }
}
