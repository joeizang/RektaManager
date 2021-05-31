using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Orders
{
    public class OrderState
    {
        public List<OrderedItemUpsertComponentModel> OrderedItems { get; set; } = new();

        public Dictionary<long, string> CurrentOrderKey { get; set; } = new();


        public List<OrderItemComponentModel> OrderItems { get; set; } = new List<OrderItemComponentModel>()
        {
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2018/08/Nigerian-Jollof-Rice.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2018/08/Nigerian-Jollof-Rice.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.royacshop.com/wp-content/uploads/2020/03/How-to-Prepare-Tuwo-Shinkafa-and-Miyan-Taushe.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://9jafoods.com/wp-content/uploads/2019/08/amala-and-ewedu-2.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2018/08/Nigerian-Jollof-Rice.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2018/08/Nigerian-Jollof-Rice.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.xycinews.com/wp-content/uploads/2019/03/water-leave-and-akpu-recipe-main-photo.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://img-global.cpcdn.com/recipes/dd2c903975f18360/751x532cq70/gwote-acha-recipe-recipe-main-photo.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2018/08/Nigerian-Jollof-Rice.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
            new OrderItemComponentModel()
            {
                ImageUrl = "https://www.preciouscore.com/wp-content/uploads/2018/08/Nigerian-Jollof-Rice.jpg",
                ItemName = "SomeItem",
                Price = 9000
            },
        };
    }
}
