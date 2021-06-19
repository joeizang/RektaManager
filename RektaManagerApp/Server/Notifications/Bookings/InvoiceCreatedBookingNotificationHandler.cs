using MediatR;
using Microsoft.AspNetCore.Identity;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Notifications.Invoices;
using RektaManagerApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RektaManagerApp.Server.Notifications.Bookings
{
    public class InvoiceCreatedBookingNotificationHandler : INotificationHandler<InvoiceCreatedNotification>
    {

        private readonly IRepository _repo;
        private readonly UserManager<ApplicationUser> _userManager;

        public InvoiceCreatedBookingNotificationHandler(IRepository repo, UserManager<ApplicationUser> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }
        public async Task Handle(InvoiceCreatedNotification notification, CancellationToken cancellationToken)
        {
            try
            {
                var newId = _repo.GenerateStringId();

                //var user = await _userManager.FindByEmailAsync(notification.CreatedBy).ConfigureAwait(false);
                var user = _userManager.Users.Where(u => u.Email.Equals(notification.CreatedBy, StringComparison.CurrentCultureIgnoreCase))
                                    .Select(x => x.Id).SingleOrDefault();

                var booking = new Booking
                {
                    Id = newId,
                    InvoiceId = notification.InvoiceId,
                    Total = notification.Total,
                    EventDate = notification.DueDate,
                    Description = notification.Description,
                    CustomerId = notification.CustomerId,
                    IsFullyPaid = notification.FullyPaid,
                    BookedItems = notification.BookedItems,
                    BookedServices = notification.Services,
                    BookingDate = notification.TransactionDate,
                    StaffId = user,
                    BookingSalesInvoices = new List<BookingSales> { new BookingSales { BookingId = newId, InvoiceId = notification.InvoiceId } }
                };

                await _repo.Add<Booking>(booking).ConfigureAwait(false);
                await _repo.Save<Booking>().ConfigureAwait(false);


                var changes = JsonSerializer.Serialize(booking);
                var audit = new BookingActionsAudit
                {
                    Actions = ActionPerformed.Created,
                    Changes = changes
                };

                await _repo.Add<BookingActionsAudit>(audit).ConfigureAwait(false);
                await _repo.Save<BookingActionsAudit>().ConfigureAwait(false);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
