using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffShiftsController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;

        public StaffShiftsController(RektaManagerAppContext context)
        {
            _context = context;
        }

        // GET: api/StaffShifts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaffShift>>> GetStaffShifts()
        {
            return await _context.StaffShifts.ToListAsync();
        }

        // GET: api/StaffShifts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaffShift>> GetStaffShift(int id)
        {
            var staffShift = await _context.StaffShifts.FindAsync(id);

            if (staffShift == null)
            {
                return NotFound();
            }

            return staffShift;
        }

        // PUT: api/StaffShifts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaffShift(int id, StaffShift staffShift)
        {
            if (id != staffShift.Id)
            {
                return BadRequest();
            }

            _context.Entry(staffShift).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffShiftExists(id))
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

        // POST: api/StaffShifts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StaffShift>> PostStaffShift(StaffShift staffShift)
        {
            _context.StaffShifts.Add(staffShift);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaffShift", new { id = staffShift.Id }, staffShift);
        }

        // DELETE: api/StaffShifts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaffShift(int id)
        {
            var staffShift = await _context.StaffShifts.FindAsync(id);
            if (staffShift == null)
            {
                return NotFound();
            }

            _context.StaffShifts.Remove(staffShift);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StaffShiftExists(int id)
        {
            return _context.StaffShifts.Any(e => e.Id == id);
        }
    }
}
