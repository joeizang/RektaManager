﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.ComponentModels.Orders;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;
        private readonly IOrderRepository _repo;

        public OrdersController(RektaManagerAppContext context, IOrderRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<List<OrderComponentModel>>> GetOrders()
        {
            var result = await _repo.GetQueryable<Order>(null, null,
                    x => x.OrderedItems, x => x.Customer)
                .Select(x => new OrderComponentModel
                {
                    CustomerName = x.Customer.Name,
                    CustomerPhone = x.Customer.PhoneNumber,
                    OrderDate = x.OrderDate,
                    OrderId = x.Id,
                    OrderTotal = x.Total,
                    StaffName = x.Staff.UserName
                }).ToListAsync().ConfigureAwait(false);
            result.ForEach(async (r) =>
            {
                r.OrderedItems = await _repo.GetQueryable<OrderedItem>(null, null, o => o.OwningOrder)
                    .Where(x => x.OrderId == r.OrderId)
                    .Select(x => new OrderedItemComponentModel
                    {
                        ItemName = x.Name,
                        ItemPrice = x.Price,
                        Quantity = x.Quantity,
                        ItemCode = x.ItemCode
                    }).ToListAsync().ConfigureAwait(false);
            });
            return Ok(result);
        }


        [HttpGet("orderItems", Name = "GetOrderItems")]
        public async Task<ActionResult<List<OrderItemComponentModel>>> GetOrderItems()
        {
            var result = await _repo.GetQueryable<OrderItem>(null, null)
                .Select(x => new OrderItemComponentModel
                {
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    ItemName = x.ItemName,
                    Price = x.Price
                }).ToListAsync();
            return Ok(result);
        }

        [HttpGet("menuItems", Name = "GetOrderItemsList")]
        public async Task<ActionResult<List<OrderItem>>> GetMenuItems()
        {
            var result = await _context.OrderItems.AsNoTracking().ToListAsync().ConfigureAwait(false);
            return Ok(result);
        }

        [HttpGet("GetOrderItem", Name = "GetOrderItemById")]
        public async Task<ActionResult<OrderItemComponentModel>> GetOrderItemById(int id)
        {
            var result = await _repo.GetQueryable<OrderItem>().Select(o => new OrderItemComponentModel
            {
                Id = o.Id,
                ImageUrl = o.ImageUrl,
                ItemName = o.ItemName,
                Price = o.Price
            }).ToListAsync().ConfigureAwait(false);

            return Ok(result);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(string id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        [HttpPut]
        public async Task<ActionResult<OrderItem>> PutOrderItem(OrderItemUpsertComponentModel model)
        {
            var target = await _context.OrderItems.FindAsync(model.OrderItemId).ConfigureAwait(false);
            var fromClient = new OrderItem { Id = model.OrderItemId, ImageUrl = model.ImageUrl, ItemName = model.ItemName, Price = model.Price };
            target.ItemName = model.ItemName;
            target.ImageUrl = model.ImageUrl;
            target.Price = model.Price;
            _context.Entry(target).State = EntityState.Modified;
            try
            {
                var audit = new OrderItemActionsAudit();
                await _repo.Update<OrderItem>(fromClient, target, audit);
                await _repo.Save<OrderItem>();
                await _repo.Save<OrderItemActionsAudit>();
                return Ok();
            }
            catch (DbUpdateException e)
            {
                await e.Entries.Single().ReloadAsync();
                await _repo.Save<OrderItem>();
                return Ok();
            }
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(string id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
