using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManager.Server.Data;
using RektaManager.Shared;
using RektaManager.Shared.ComponentModels.Inventories;

namespace RektaManager.Server.Controllers
{
    [Route("api/selectInventories")]
    [ApiController]
    public class SelectInventoriesController : ControllerBase
    {
        private readonly RektaManagerContext _context;

        public SelectInventoriesController(RektaManagerContext context)
        {
            _context = context;
        }

        // GET: api/SelectInventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventorySelectModel>>> GetInventories()
        {
            var result = await _context.Inventories.AsNoTracking()
                .Select(i => new InventorySelectModel()
                {
                    InventoryId = i.Id,
                    InventoryName = i.Name
                }).ToArrayAsync();
            return Ok(result);
        }

        // GET: api/SelectInventories/5
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

        private bool InventoryExists(int id)
        {
            return _context.Inventories.Any(e => e.Id == id);
        }
    }
}
