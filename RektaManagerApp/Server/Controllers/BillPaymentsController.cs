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
    public class BillPaymentsController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;

        public BillPaymentsController(RektaManagerAppContext context)
        {
            _context = context;
        }

        // GET: api/BillPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillPayment>>> GetBillPayments()
        {
            return await _context.BillPayments.ToListAsync();
        }

        // GET: api/BillPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BillPayment>> GetBillPayment(int id)
        {
            var billPayment = await _context.BillPayments.FindAsync(id);

            if (billPayment == null)
            {
                return NotFound();
            }

            return billPayment;
        }

        // PUT: api/BillPayments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBillPayment(int id, BillPayment billPayment)
        {
            if (id != billPayment.Id)
            {
                return BadRequest();
            }

            _context.Entry(billPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillPaymentExists(id))
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

        // POST: api/BillPayments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BillPayment>> PostBillPayment(BillPayment billPayment)
        {
            _context.BillPayments.Add(billPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBillPayment", new { id = billPayment.Id }, billPayment);
        }

        // DELETE: api/BillPayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBillPayment(int id)
        {
            var billPayment = await _context.BillPayments.FindAsync(id);
            if (billPayment == null)
            {
                return NotFound();
            }

            _context.BillPayments.Remove(billPayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BillPaymentExists(int id)
        {
            return _context.BillPayments.Any(e => e.Id == id);
        }
    }
}
