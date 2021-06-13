// unset

using MediatR;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Server.Notifications.Orders;
using RektaManagerApp.Shared;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RektaManagerApp.Server.Notifications.Inventory
{
    public class OrderCompletedInventoryNotificationHandler : INotificationHandler<OrderCompletedNotification>
    {
        private readonly RektaManagerAppContext _context;
        private readonly IRepository _repo;

        public OrderCompletedInventoryNotificationHandler(RektaManagerAppContext context, IRepository repo)
        {
            _context = context;
            _repo = repo;
        }
        public async Task Handle(OrderCompletedNotification notification, CancellationToken cancellationToken)
        {
            try
            {
                notification.OrderedItems.ForEach(async (o) =>
                {
                    var match = await _context.Products.AsNoTracking()
                        .SingleOrDefaultAsync(p => p.Name.Contains(o.Name), cancellationToken)
                        .ConfigureAwait(false);
                    match.QuantityBought -= o.Quantity;
                    // _context.Entry(match).State = EntityState.Modified;
                    await _repo.Update<Product>(new Product {Id = match.Id}, match, new ProductActionsAudit())
                        .ConfigureAwait(false);
                    await _repo.Save<Product>();
                });
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}