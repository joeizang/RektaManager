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
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

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
