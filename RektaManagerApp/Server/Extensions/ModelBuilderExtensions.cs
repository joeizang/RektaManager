// unset

using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Shared;
using System;

namespace RektaManagerApp.Server.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder, UserManager<ApplicationUser> userManager)
        {
            builder.Entity<InventoryCategory>().HasData(
                new InventoryCategory
                {
                    Id = 1,
                    Name = "SOFT DRINKS",
                    Description = "Non Alcoholic drinks",
                    CreatedBy = "SYSTEM",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedBy = "SYSTEM",
                    Timestamp = DateTime.UtcNow
                },
                new InventoryCategory
                {
                    Id = 2,
                    Name = "DRINKS",
                    Description = "Alcoholic Beverage drinks",
                    CreatedBy = "SYSTEM",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedBy = "SYSTEM",
                    Timestamp = DateTime.UtcNow
                },
                new InventoryCategory
                {
                    Id = 3,
                    Name = "WINE AND SPIRITS",
                    Description = "Both alcoholic and non alcoholic drinks",
                    CreatedBy = "SYSTEM",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedBy = "SYSTEM",
                    Timestamp = DateTime.UtcNow
                },
                new InventoryCategory
                {
                    Id = 4,
                    Name = "FOODS",
                    Description = "Cooked Food and other types of Food",
                    CreatedBy = "SYSTEM",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedBy = "SYSTEM",
                    Timestamp = DateTime.UtcNow
                });
            builder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    Id = 1,
                    ItemName = "Semovita/Any Soup",
                    Price = 600,
                    ItemCode = "Semo-Any",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 2,
                    ItemName = "Eba/Any Soup",
                    Price = 600,
                    ItemCode = "Eba-Any",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 3,
                    ItemName = "Beans-Plantain",
                    Price = 500,
                    ItemCode = "Beans-P",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 4,
                    ItemName = "Fried Rice",
                    Price = 700,
                    ItemCode = "F-Rice",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 5,
                    ItemName = "Jollof Rice",
                    Price = 600,
                    ItemCode = "J-Rice",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 6,
                    ItemName = "Rice-Stew",
                    Price = 600,
                    ItemCode = "Rice-Stew",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 7,
                    ItemName = "Chips-Eggs",
                    Price = 700,
                    ItemCode = "Chips-Eggs",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 8,
                    ItemName = "Indomie-Egg",
                    Price = 700,
                    ItemCode = "IndomieEgg",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 9,
                    ItemName = "Leaf Moimoi",
                    Price = 200,
                    ItemCode = "LeafMoimoi",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 10,
                    ItemName = "CowLeg P.Soup",
                    Price = 1000,
                    ItemCode = "CowLeg",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 11,
                    ItemName = "CowTail P.Soup",
                    Price = 1000,
                    ItemCode = "Cowtail",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 12,
                    ItemName = "Fresh Fish",
                    Price = 800,
                    ItemCode = "Fresh-Fish",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 13,
                    ItemName = "Intestine",
                    Price = 600,
                    ItemCode = "Intestine",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 14,
                    ItemName = "Peppered Chicken",
                    Price = 800,
                    ItemCode = "PepChicken",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 15,
                    ItemName = "Asun",
                    Price = 700,
                    ItemCode = "PepGoat",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 16,
                    ItemName = "Gizdodo",
                    Price = 600,
                    ItemCode = "Gizdodo",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 17,
                    ItemName = "Coleslaw",
                    Price = 200,
                    ItemCode = "Coleslaw",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 18,
                    ItemName = "Mixed Salad",
                    Price = 500,
                    ItemCode = "MixedSalad",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 19,
                    ItemName = "Potato Salad",
                    Price = 1000,
                    ItemCode = "Semo-Any",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 20,
                    ItemName = "Shawarma Chicken",
                    Price = 1200,
                    ItemCode = "ShwmChick",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 21,
                    ItemName = "Shawarma Beef",
                    Price = 800,
                    ItemCode = "ShwmBeef",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 22,
                    ItemName = "Burger",
                    Price = 1000,
                    ItemCode = "ShwmChick",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 23,
                    ItemName = "Roasted Tilapia",
                    Price = 2000,
                    ItemCode = "TilapiaBig",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 24,
                    ItemName = "Roasted Tilapia",
                    Price = 1800,
                    ItemCode = "TilapiaSm",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 25,
                    ItemName = "Steamed Catfish",
                    Price = 3500,
                    ItemCode = "StmCatfish",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 26,
                    ItemName = "Steamed Catfish",
                    Price = 3000,
                    ItemCode = "CatfishSm",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 27,
                    ItemName = "Isiewu",
                    Price = 800,
                    ItemCode = "Isiewu",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 28,
                    ItemName = "Heineken",
                    Price = 450,
                    ItemCode = "Heineken",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 29,
                    ItemName = "Medium Stout",
                    Price = 400,
                    ItemCode = "MedStout",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 30,
                    ItemName = "Extra Smooth",
                    Price = 400,
                    ItemCode = "ExSmooth",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 31,
                    ItemName = "Smirnoff Ice",
                    Price = 500,
                    ItemCode = "Smirnoff",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 32,
                    ItemName = "Big Origin",
                    Price = 450,
                    ItemCode = "Big-Origin",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 33,
                    ItemName = "Tiger",
                    Price = 300,
                    ItemCode = "Tiger",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 34,
                    ItemName = "Radler",
                    Price = 300,
                    ItemCode = "Radler",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 35,
                    ItemName = "Gulder",
                    Price = 350,
                    ItemCode = "Gulder",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 36,
                    ItemName = "Golfberg",
                    Price = 300,
                    ItemCode = "Golfberg",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 37,
                    ItemName = "Star",
                    Price = 300,
                    ItemCode = "Star",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 38,
                    ItemName = "StarLite",
                    Price = 300,
                    ItemCode = "StarLite",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 39,
                    ItemName = "Legend",
                    Price = 450,
                    ItemCode = "Legend",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 40,
                    ItemName = "Castle-Lite",
                    Price = 350,
                    ItemCode = "CastleLite",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 41,
                    ItemName = "Double-Black",
                    Price = 350,
                    ItemCode = "D-Black",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 42,
                    ItemName = "Hero",
                    Price = 300,
                    ItemCode = "Hero",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 43,
                    ItemName = "Trophy",
                    Price = 300,
                    ItemCode = "Trophy",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 44,
                    ItemName = "Budweiser",
                    Price = 450,
                    ItemCode = "Budweiser",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 45,
                    ItemName = "Coke",
                    Price = 300,
                    ItemCode = "Coke",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 46,
                    ItemName = "Sprite",
                    Price = 300,
                    ItemCode = "Sprite",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 47,
                    ItemName = "Fanta",
                    Price = 300,
                    ItemCode = "Fanta",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 48,
                    ItemName = "Can Malt",
                    Price = 300,
                    ItemCode = "Can-Malt",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 49,
                    ItemName = "Bottled Malt",
                    Price = 300,
                    ItemCode = "MaltBottle",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 50,
                    ItemName = "Juice",
                    Price = 500,
                    ItemCode = "Juice",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 51,
                    ItemName = "Water",
                    Price = 100,
                    ItemCode = "Water",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 52,
                    ItemName = "Energy Drink",
                    Price = 500,
                    ItemCode = "EnergyDnk",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 53,
                    ItemName = "Mateaus",
                    Price = 3000,
                    ItemCode = "Mateaus",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 54,
                    ItemName = "DonFelder",
                    Price = 3000,
                    ItemCode = "Donfed",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 55,
                    ItemName = "Four Cousins",
                    Price = 2700,
                    ItemCode = "Donfed",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                },
                new OrderItem
                {
                    Id = 56,
                    ItemName = "Baron",
                    Price = 2000,
                    ItemCode = "Baron",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime
                }
            );
        }
    }
}