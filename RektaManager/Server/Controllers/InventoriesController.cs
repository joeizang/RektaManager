using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManager.Server.Commands.Inventories;
using RektaManager.Server.Data;
using RektaManager.Server.Queries.Inventories;
using RektaManager.Shared;
using RektaManager.Shared.ComponentModels.Inventories;

namespace RektaManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly RektaManagerContext _context;

        public InventoriesController(RektaManagerContext context)
        {
            _context = context;
        }

        // GET: api/Inventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryComponentModel>>> GetInventories(CancellationToken token = default)
        {
            var inventories = _context.Inventories.AsNoTracking();

            return Ok(await inventories.Include(x => x.InventoryCategories).OrderBy(x => x.SupplyDate)
                .ThenBy(x => x.Id)
                .Select(x => new InventoryComponentModel()
                {
                    CategoryName = x.InventoryCategories.First().Name,
                    InventoryDate = x.SupplyDate,
                    InventoryName = x.Name,
                    QuantityInStock = x.Quantity,
                    InventoryId = x.Id
                }).ToListAsync(token));
        }

        // GET: api/Inventories/5
        [HttpGet("{id}", Name = "GetOneInventory")]
        public async Task<ActionResult<Inventory>> GetInventory(int id)
        {
            var inventory = _context.Inventories.AsNoTracking();

            var mainResult = await inventory.Select(i => new InventoryDetailComponentModel()
            {
                InventoryName = i.Name,
                InventoryQuantity = i.Quantity,
                Date = i.SupplyDate
            }).SingleOrDefaultAsync();

            var categories = await inventory
                .Include(i => i.InventoryCategories)
                .Where(x => x.Id == id)
                .Select(p => p.InventoryCategories.Single())
                .Select(c => c.Name)
                .ToListAsync();

            var products = await _context.Products.AsNoTracking()
                .Include(p => p.ProductInventory)
                .Where(p => p.ProductInventory.Id == id)
                .Select(p => p.Name)
                .ToListAsync();

            mainResult.InventoryCategories = categories;
            mainResult.ProductNames = products;

            if (mainResult is null)
            {
                return NotFound();
            }

            return Ok(mainResult);
        }

        // PUT: api/Inventories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory(PutInventoryCommand inventory, CancellationToken token = default)
        {
            var fromDb = await _context.Inventories.SingleOrDefaultAsync(i => i.Id == inventory.Id, token)
                .ConfigureAwait(false);
            if (fromDb is null)
            {
                return BadRequest();
            }

            fromDb.Name = inventory.Name;
            fromDb.Price = inventory.Price;
            fromDb.Quantity = inventory.Quantity;
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
                        Price = inventory.Price,
                        Quantity = inventory.Quantity,
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
                        Name = inventory.Name,
                        Price = inventory.Price,
                        Quantity = inventory.Quantity,
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
