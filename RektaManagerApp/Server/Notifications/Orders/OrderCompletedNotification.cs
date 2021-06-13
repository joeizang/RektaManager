// unset

using MediatR;
using RektaManagerApp.Shared;
using System;
using System.Collections.Generic;

namespace RektaManagerApp.Server.Notifications.Orders
{
    public class OrderCompletedNotification : INotification
    {
        public string OrderId { get; set; }

        public decimal OrderTotal { get; set; }

        public List<OrderedItem> OrderedItems { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public string StaffId { get; set; }
    }
}