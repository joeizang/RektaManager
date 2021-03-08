using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult<IEnumerable<InventoryComponentModel>>> GetInventories([FromQuery] GetInventoriesQuery query, CancellationToken token = default)
        {
            var inventories = _context.Inventories.AsNoTracking();
            if (string.IsNullOrEmpty(query.InventoryName))
            {
                inventories = inventories.Where(i => i.Price.Equals(query.Price));
            }

            inventories = inventories.Where(i => i.Name.Contains(query.InventoryName) || i.Price.Equals(query.Price));

            DateTimeOffset newDateRange;
            
            if (query.DateOffset > 0)
            {
                newDateRange = query.Date.AddDays(query.DateOffset);
                inventories = inventories.Where(i => i.SupplyDate >= query.Date && i.SupplyDate <= newDateRange);
            }

            inventories = inventories.Where(i => i.SupplyDate >= query.Date);

            var result = await inventories.Select(x => new InventoryComponentModel()
            {
                InventoryDate = x.SupplyDate,
                InventoryName = x.Name,
                InventoryId = x.Id,
                QuantityInStock = x.Quantity,
                CategoryName = x.InventoryCategories.FirstOrDefault().Name
            }).ToListAsync(token).ConfigureAwait(false);

            return Ok(result);
        }

        // GET: api/Inventories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventory>> GetInventory(int id)
        {
            var inventory = await _context.Inventories.FindAsync(id);

            if (inventory == null)
            {
                return NotFound();
            }

            return inventory;
        }

        // PUT: api/Inventories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory(int id, Inventory inventory)
        {
            if (id != inventory.Id)
            {
                return BadRequest();
            }

            _context.Entry(inventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryExists(id))
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

        // POST: api/Inventories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inventory>> PostInventory(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventory", new { id = inventory.Id }, inventory);
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
