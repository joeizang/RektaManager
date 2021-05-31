using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.ComponentModels.Inventories;
using RektaManagerApp.Shared.ComponentModels.Products;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/inventories")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;

        public InventoriesController(RektaManagerAppContext context)
        {
            _context = context;
        }

        // GET: api/Inventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryComponentModel>>> GetInventories(CancellationToken token = default)
        {
            var inventories = _context.Inventories.AsNoTracking();
            var products = _context.Products.AsNoTracking();

            inventories = inventories.Include(i => i.InventoryCategories);
            products = products.Include(p => p.ProductInventory);

            var inventoryEnumerable = await inventories.Select(i => new InventoryComponentModel
            {
                InventoryId = i.Id,
                InventoryDate = i.SupplyDate,
                InventoryName = i.Name,
                CategoryName = i.InventoryCategories.First().Name
            }).ToListAsync(token).ConfigureAwait(false);

            var productEnumerable = await products
                .Select(p => new {p.QuantityBought, p.ProductInventoryId})
                .ToListAsync(token).ConfigureAwait(false);

            inventoryEnumerable.ForEach(one =>
            {
                foreach (var product in productEnumerable)
                {
                    if (product.ProductInventoryId == one.InventoryId)
                    {
                        one.QuantityInStock += product.QuantityBought;
                    }
                }
            });
            
            return Ok(inventoryEnumerable);
        }

        // GET: api/Inventories/5
        [HttpGet("{id:int}", Name = "GetOneInventory")]
        public async Task<ActionResult<InventoryDetailComponentModel>> GetInventory(int id)
        {
            var inventory = _context.Inventories
                .AsNoTracking()
                .Where(i => i.Id == id);
            var products = await _context.Products.AsNoTracking()
                .Where(p => p.ProductInventoryId == id)
                .Select(x => new ProductComponentModel
                {
                    Name = x.Name,
                    UnitMeasure = x.UnitMeasure,
                    QuantityBought = x.QuantityBought,
                }).ToListAsync().ConfigureAwait(false);

            var mainResult = await inventory.Select(i =>
                new InventoryDetailComponentModel()
                {
                    Name = i.Name,
                    Date = i.SupplyDate,
                    Products = products,
                    InventoryCategories = i.InventoryCategories.Select(x => x.Name).ToList(),
                    InventoryId = i.Id,
                }).SingleOrDefaultAsync().ConfigureAwait(false);

            if (mainResult is null)
            {
                return NotFound();
            }

            return Ok(mainResult);
        }

        // GET: api/Inventories/5
        [Route("api/inventories/{id}/more/{moreDetails:bool}")]
        public async Task<ActionResult<InventoryDetailComponentModel>> GetMoreInventoryDetails(int id, bool moreDetails)
        {
            var inventory = _context.Inventories
                .AsNoTracking()
                .Where(i => i.Id == id);

            var mainResult = new InventoryDetailComponentModel();
            var categories = new List<string>();
            var products = new List<ProductComponentModel>();

            if (moreDetails)
            {
                categories = await inventory
                    .Include(i => i.InventoryCategories)
                    .Where(x => x.Id == id)
                    .Select(p => p.InventoryCategories.Single())
                    .Select(c => c.Name)
                    .ToListAsync();

                products = await _context.Products.AsNoTracking()
                    .Include(p => p.ProductInventory)
                    .Where(p => p.ProductInventory.Id == id)
                    .Select(p => new ProductComponentModel
                    {
                        ProductId = p.Id,
                        Name = p.Name,
                        QuantityBought = p.QuantityBought,
                        UnitMeasure = p.UnitMeasure
                    })
                    .ToListAsync();
            }

            mainResult.InventoryCategories = categories;
            mainResult.Products = products;


            return Ok(mainResult);
        }

        // PUT: api/Inventories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory([FromBody]InventoryUpsertComponentModel inventory, CancellationToken token = default)
        {
            var fromDb = await _context.Inventories.Where(i => i.Id == inventory.Id).SingleOrDefaultAsync(token)
                .ConfigureAwait(false);
            if (fromDb is null)
            {
                return BadRequest();
            }

            fromDb.Name = inventory.Name;
            fromDb.SupplyDate = inventory.SupplyDate;
            _context.Entry(fromDb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(token).ConfigureAwait(false);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryExists(inventory.Id))
                {
                    var target = new Inventory()
                    {
                        Name = inventory.Name,
                        SupplyDate = inventory.SupplyDate
                    };
                    _context.Inventories.Add(target);
                    var id = await _context.SaveChangesAsync(token).ConfigureAwait(false);
                    return RedirectToRoute("GetOneInventory", new { Id = id });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Inventories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostInventory(InventoryUpsertComponentModel
         inventory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newInventory = new Inventory()
                    {
                        Name = inventory.Name.ToUpper(),
                        SupplyDate = inventory.SupplyDate
                    };
                    _context.Inventories.Add(newInventory);
                    var newId = await _context.SaveChangesAsync().ConfigureAwait(false);
                    inventory.Id = newId;
                }
                return CreatedAtAction("GetInventory", new { id = inventory.Id }, inventory);
            }
            catch (System.Exception ex)
            {
                return BadRequest(new {ex.Message });
            }
        }

        // DELETE: api/Inventories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventory(int id)
        {
            var inventory = await _context.Inventories.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }

            _context.Inventories.Remove(inventory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventoryExists(int id)
        {
            return _context.Inventories.Any(e => e.Id == id);
        }
    }
}
