using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.ComponentModels.Bookings;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;
        private readonly IRepository _repo;

        public BookingsController(RektaManagerAppContext context, IRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingComponentModel>>> GetBookings()
        {
            var query = _repo.GetQueryable<Booking>(null, null, b => b.BookedItems,
                b => b.BookedServices, b => b.Customer, b => b.Invoice,
                b => b.StaffProcessing);
            var result = await query.Select(b => new BookingComponentModel
                {
                    BookedBy = b.StaffProcessing.UserName,
                    BookingDate = b.BookingDate.LocalDateTime,
                    CustomerName = b.Customer.Name,
                    EventDate = b.EventDate.LocalDateTime,
                    BookingId = b.Id,
                    IsFullyPaid = b.IsFullyPaid,
                    IsPartPaid = b.IsPartPayment
                }).ToListAsync().ConfigureAwait(false);

            return result;
        }

        [HttpGet("bookedItemDropDown", Name = "GetBookedItemDropDown")]
        public async Task<ActionResult<IEnumerable<BookedItemDropdownModel>>> GetDropDown()
        {
            var result = await _context.BookedItems.AsNoTracking()
                .Select(s => new BookedItemDropdownModel
                {
                    BookedItemId = s.Id,
                    ItemName = s.Name
                }).ToListAsync().ConfigureAwait(false);
            return result;
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(string id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _context.Entry(booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(id))
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

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingExists(string id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
