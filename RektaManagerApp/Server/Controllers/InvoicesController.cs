using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Server.Notifications.Invoices;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.ComponentModels.Invoices;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;
        private readonly IRepository _repo;
        private readonly IMediator _mediator;

        public InvoicesController(RektaManagerAppContext context, IRepository repo, IMediator mediator)
        {
            _context = context;
            _repo = repo;
            _mediator = mediator;
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceListComponentModel>>> GetInvoice()
        {
            var invoices = await _context.Invoices.AsNoTracking()
                .Select(x => new InvoiceListComponentModel
                {
                    CustomerName = x.Customer.Name,
                    DueDate = x.DueDate,
                    InvoicePaymentStatus = x.FullyPaid,
                    NumberOfOrders = x.Orders.Count,
                    TransactionDate = x.TransactionDate
                }).ToListAsync().ConfigureAwait(false);
            return Ok(invoices);
        }

        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invoice>> GetInvoice(string id)
        {
            var invoice = await _context.Invoices.FindAsync(id);

            if (invoice == null)
            {
                return NotFound();
            }

            return invoice;
        }

        // PUT: api/Invoices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoice(string id, Invoice invoice)
        {
            if (id != invoice.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceExists(id))
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

        // POST: api/Invoices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvoiceComponentModel>> PostInvoice(InvoiceUpsertComponentModel model)
        {
            var newId = _repo.GenerateStringId();
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var invoice = new Invoice
                {
                    Id = newId,
                    Description = model.Description,
                    DueDate = model.DueDate,
                    TransactionDate = model.TransactionDate,
                    FullyPaid = model.FullyPaid,
                    Customer = new Customer { Name = model.CustomerName, PhoneNumber = model.CustomerPhone },
                    Total = model.Total,
                    CreatedBy = model.AttendingStaff
                };
                var bookedItems = new List<BookedItem>();
                var services = new List<Service>();

                if(model.BookedItems.Any())
                {
                    model.BookedItems.ForEach(b => 
                    {
                        bookedItems.Add(new BookedItem { Id = b });
                    });
                }

                if(model.Services.Any())
                {
                    model.Services.ForEach(s =>
                    {
                        services.Add(new Service { Id = s });
                    });
                }


                
                _context.Invoices.Add(invoice);
                await _repo.Save<Invoice>().ConfigureAwait(false);

                var customerId = await _context.Customers.AsNoTracking()
                    .Include(c => c.CustomerInvoices.Where(i => i.Id.Equals(newId)))
                    .Select(c => new
                    {
                        CustomerId = c.Id
                    }).SingleOrDefaultAsync().ConfigureAwait(false);

                var notification = new InvoiceCreatedNotification
                {
                    Description = model.Description,
                    DueDate = model.DueDate,
                    Total = model.Total,
                    FullyPaid = model.FullyPaid,
                    InvoiceId = newId,
                    TransactionDate = model.TransactionDate,
                    CustomerId = customerId.CustomerId,
                    CreatedBy = model.AttendingStaff
                };

                await _mediator.Publish<InvoiceCreatedNotification>(notification);

                return CreatedAtAction("GetInvoice", new { id = invoice.Id }, invoice);
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = e.Message });
            }
        }

        // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }

            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceExists(string id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}
