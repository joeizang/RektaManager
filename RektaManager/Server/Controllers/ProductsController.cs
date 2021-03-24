using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.ProductInventory)
                .Include(c => c.ProductCategories)
                .Where(p => p.Id == id)
                .SingleOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, [FromBody]Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            var uuidTest = _context.Products.AsNoTracking()
                .Any(x => x.ProductUniqueIdentifier.Equals(product.ProductUniqueIdentifier));

            //_context.Entry(fromDb).State = EntityState.Modified;
            _context.Products.Attach(product);
            
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToRoute("GetProductById", new { id = product.Id });
            }
            catch (DbUpdateConcurrencyException e)
            {
                //if there was an exception, then the last update from the application wins and will be saved to the database
                foreach (var item in e.Entries)
                {
                    if (item.Entity is Product)
                    {
                        var currentValuesFromApp = item.CurrentValues;
                        var valuesInDb = await item.GetDatabaseValuesAsync();

                        foreach (var target in currentValuesFromApp.Properties)
                        {
                            var sampleTargetProperty = currentValuesFromApp[target];
                            var dbVal = valuesInDb[target];
                        }

                        item.OriginalValues.SetValues(valuesInDb);
                        await item.ReloadAsync();
                        await _context.SaveChangesAsync();
                        return RedirectToRoute("GetProductById", new { id = product.Id });
                    }
                    else
                    {
                        throw new NotSupportedException("There is a conflict in saving your changes!");
                    }
                }

            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct([FromBody]Product product)
        {
            var newId = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Products.Add(product);
                    newId = await _context.SaveChangesAsync();
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(new { e.Message});
            }

            
            return CreatedAtAction("GetProduct", new { id = newId }, product);
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
                .ToArrayAsync();
        }
    }
}
