// unset

using Microsoft.AspNetCore.Identity;
using RektaManagerApp.Shared;
using System;
using System.Threading.Tasks;

namespace RektaManagerApp.Server.Extensions
{
    public static class SeedApplicationUsers
    {
        public static async Task SeedAppUsers(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            if (roleManager.FindByNameAsync("Admin").Result == null &&
                roleManager.FindByNameAsync("Owner").Result == null &&
                roleManager.FindByNameAsync("User").Result == null)
            {
                var adminRole = new ApplicationRole
                {
                    Name = "Admins", CreatedAt = DateTimeOffset.UtcNow.LocalDateTime, Id = Guid.NewGuid().ToString()
                };
                var userRole = new ApplicationRole
                {
                    Name = "Users", CreatedAt = DateTimeOffset.UtcNow.LocalDateTime, Id = Guid.NewGuid().ToString()
                };
                var ownerRole = new ApplicationRole
                {
                    Name = "Owner", CreatedAt = DateTimeOffset.UtcNow.LocalDateTime, Id = Guid.NewGuid().ToString()
                };
                roleManager.CreateAsync(adminRole).Wait();
                roleManager.CreateAsync(ownerRole).Wait();
                roleManager.CreateAsync(userRole).Wait();
            }
            
            if (userManager.FindByEmailAsync("salesUser@rektaparkgardens.com").Result == null)
            {
                var salesUser = new ApplicationUser
                {
                    FirstName = "SalesUser",
                    LastName = "RektaParkandGardens",
                    Id = Guid.NewGuid().ToString(),
                    Email = "salesUser@rektaparkgardens.com",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                };
                var result = userManager.CreateAsync(salesUser, "salesP@ssword1").Result;
                if (result.Succeeded)
                    userManager.AddToRoleAsync(salesUser, "Users").Wait();
            }
            
            if (userManager.FindByEmailAsync("owner@rektaparkgardens.com").Result == null)
            {
                var owner = new ApplicationUser
                {
                    FirstName = "Owner",
                    LastName = "RektaParkandGardens",
                    Id = Guid.NewGuid().ToString(),
                    Email = "owner@rektaparkgardens.com",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                };
                var result = userManager.CreateAsync(owner, "ownerP@ssword1").Result;
                if (result.Succeeded)
                    userManager.AddToRolesAsync(owner, new string[] {"Owner", "Admin"}).Wait();
            }
            
            if (userManager.FindByEmailAsync("admin@rektaparkgardens.com").Result == null)
            {
                var admin = new ApplicationUser
                {
                    FirstName = "Admin",
                    LastName = "RektaParkandGardens",
                    Id = Guid.NewGuid().ToString(),
                    Email = "admin@rektaparkgardens.com",
                    CreatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                    UpdatedAt = DateTimeOffset.UtcNow.LocalDateTime,
                };
                var result = userManager.CreateAsync(admin, "adminP@ssword1").Result;
                if (result.Succeeded)
                    userManager.AddToRoleAsync(admin, "Admin").Wait();
            }
        }
    }
}