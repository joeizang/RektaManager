using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RektaManager.Server.Abstractions;
using RektaManager.Server.Data;
using RektaManager.Shared.Abstractions;
using RektaManager.Shared.ComponentModels.Orders;

namespace RektaManager.Server.Services
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        private readonly RektaManagerContext _context;

        public OrderRepository(RektaManagerContext context, IHttpContextAccessor httpContext) : base(context, httpContext)
        {
            _context = context;
        }

        public async Task<OrderComponentModel> GetOrderBy(string searchTerm)
        {
            var orderQuery = _context.Orders.AsNoTracking().Include(o => o.OrderedItems)
                .Where(o => o.Customer.Name.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase));
            var orderedItems = _context.OrderedItems.AsNoTracking()
                .Where(o => o.Name.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                            && o.ItemCode.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                            && o.Price.Equals(decimal.Parse(searchTerm)) &&
                            o.Quantity.Equals(double.Parse(searchTerm)));
            var result = await orderQuery.Where(o => o.Id == orderedItems.SingleOrDefault().OrderId)
                .Select(x => new OrderComponentModel()
                {
                    CustomerName = x.Customer.Name,
                    CustomerPhone = x.Customer.PhoneNumber,
                    OrderDate = x.OrderDate,
                    OrderTotal = x.Total,
                    StaffName = $"{x.Staff.FirstName} {x.Staff.LastName}",
                    OrderId = x.Id
                }).SingleOrDefaultAsync();
            var items = await orderedItems.Where(o => o.OrderId == result.OrderId)
                .Select(x => new OrderedItemComponentModel
                {
                    ItemCode = x.ItemCode,
                    ItemName = x.Name,
                    ItemPrice = x.Price,
                    Quantity = x.Quantity
                }).ToListAsync();
            result.OrderedItems = items;
            return result;
        }

        public async Task<OrderedItemComponentModel> GetOrderedItemBy(string searchTerm)
        {
            var orderedItem = await _context.OrderedItems.AsNoTracking()
                .Where(o => o.Name.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                            && o.ItemCode.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                            && o.Price.Equals(decimal.Parse(searchTerm)) &&
                            o.Quantity.Equals(double.Parse(searchTerm)))
                .Select(x => new OrderedItemComponentModel
                {
                    ItemCode = x.ItemCode,
                    ItemName = x.Name,
                    ItemPrice = x.Price,
                    Quantity = x.Quantity
                }).SingleOrDefaultAsync();
            return orderedItem;
        }

        public async Task<OrderItemComponentModel> GetOrderItemBy(string searchTerm)
        {
            var orderItem = await _context.OrderItems.AsNoTracking()
                .Where(o => o.ItemName.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                            && o.ImageUrl.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                            && o.Price.Equals(decimal.Parse(searchTerm)))
                .Select(x => new OrderItemComponentModel()
                {
                    ImageUrl = x.ImageUrl,
                    ItemName = x.ItemName,
                    Price = x.Price,
                    Id = x.Id
                }).SingleOrDefaultAsync();
            return orderItem;
        }

        public IQueryable<T> GetQueryable<T>(Expression<Func<T, bool>>[] predicates = null, 
            RequestCustomizer query = null, params Expression<Func<T, object>>[] includes) where T : DomainModelBase
        {
            var queryable = _context.Set<T>().AsNoTracking();
            if(query is null && predicates is null)
            {
                foreach(var include in includes)
                {
                    queryable = queryable.Include(include);
                }

                return queryable;
            }

            var index = 0;
            if (predicates is not null && query is not null)
            {
                if (includes.Length > 0)
                {
                    while (index <= predicates.Length)
                    {
                        queryable = queryable.Where(predicates[index]);
                        index++;
                    }
                }
            }

            return queryable;
        }

        public Task Update(OrderUpsertComponentModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
