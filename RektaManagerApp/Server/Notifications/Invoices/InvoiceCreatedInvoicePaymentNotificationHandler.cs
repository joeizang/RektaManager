using MediatR;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RektaManagerApp.Server.Notifications.Invoices
{
    public class InvoiceCreatedInvoicePaymentNotificationHandler : INotificationHandler<InvoiceCreatedNotification>
    {
        private readonly IRepository _repo;

        private readonly RektaManagerAppContext _context;

        public InvoiceCreatedInvoicePaymentNotificationHandler(IRepository repo, RektaManagerAppContext context)
        {
            _repo = repo;
            _context = context;
        }
        public async Task Handle(InvoiceCreatedNotification notification, CancellationToken cancellationToken)
        {
            try
            {
                var payment = new InvoicePayment
                {
                    Id = _repo.GenerateStringId(),
                    Description = notification.Description,
                    FullPayment = notification.FullyPaid,
                    Total = notification.Total,
                    Reference = $"Referenced by invoice code : {notification.InvoiceId} ",
                    TransactionDate = notification.TransactionDate,
                    CreatedBy = notification.CreatedBy
                };

                _context.InvoicePayments.Add(payment);
                await _repo.Save<InvoicePayment>().ConfigureAwait(false);

                var changes = JsonSerializer.Serialize(payment, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                var audit = new InvoicePaymentsActionAudit
                {
                    Actions = ActionPerformed.Created,
                    Changes = changes
                };
                _context.Add(audit);
                await _repo.Save<InvoicePaymentsActionAudit>().ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
