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
    public class InvoicePaymentsController : ControllerBase
    {
        private readonly RektaManagerContext _context;

        public InvoicePaymentsController(RektaManagerContext context)
        {
            _context = context;
        }

        // GET: api/InvoicePayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoicePayment>>> GetInvoicePayment()
        {
            return await _context.InvoicePayment.ToListAsync();
        }

        // GET: api/InvoicePayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoicePayment>> GetInvoicePayment(int id)
        {
            var invoicePayment = await _context.InvoicePayment.FindAsync(id);

            if (invoicePayment == null)
            {
                return NotFound();
            }

            return invoicePayment;
        }

        // PUT: api/InvoicePayments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoicePayment(int id, InvoicePayment invoicePayment)
        {
            if (id != invoicePayment.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoicePayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoicePaymentExists(id))
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

        // POST: api/InvoicePayments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvoicePayment>> PostInvoicePayment(InvoicePayment invoicePayment)
        {
            _context.InvoicePayment.Add(invoicePayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoicePayment", new { id = invoicePayment.Id }, invoicePayment);
        }

        // DELETE: api/InvoicePayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoicePayment(int id)
        {
            var invoicePayment = await _context.InvoicePayment.FindAsync(id);
            if (invoicePayment == null)
            {
                return NotFound();
            }

            _context.InvoicePayment.Remove(invoicePayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoicePaymentExists(int id)
        {
            return _context.InvoicePayment.Any(e => e.Id == id);
        }
    }
}
