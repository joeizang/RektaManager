using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManager.Server.Data;
using RektaManager.Shared;

namespace RektaManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryCategoriesController : ControllerBase
    {
        private readonly RektaManagerContext _context;

        public InventoryCategoriesController(RektaManagerContext context)
        {
            _context = context;
        }

        // GET: api/InventoryCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryCategory>>> GetInventoryCategories()
        {
            return await _context.InventoryCategories.ToListAsync();
        }

        // GET: api/InventoryCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryCategory>> GetInventoryCategory(int id)
        {
            var inventoryCategory = await _context.InventoryCategories.FindAsync(id);

            if (inventoryCategory == null)
            {
                return NotFound();
            }

            return inventoryCategory;
        }

        // PUT: api/InventoryCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryCategory(int id, InventoryCategory inventoryCategory)
        {
            if (id != inventoryCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(inventoryCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryCategoryExists(id))
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

        // POST: api/InventoryCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InventoryCategory>> PostInventoryCategory(InventoryCategory inventoryCategory)
        {
            _context.InventoryCategories.Add(inventoryCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventoryCategory", new { id = inventoryCategory.Id }, inventoryCategory);
        }

        // DELETE: api/InventoryCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryCategory(int id)
        {
            var inventoryCategory = await _context.InventoryCategories.FindAsync(id);
            if (inventoryCategory == null)
            {
                return NotFound();
            }

            _context.InventoryCategories.Remove(inventoryCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventoryCategoryExists(int id)
        {
            return _context.InventoryCategories.Any(e => e.Id == id);
        }
    }
}
