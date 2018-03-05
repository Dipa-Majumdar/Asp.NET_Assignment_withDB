using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data;

namespace test.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductInventoryDbContext(
             serviceProvider.GetRequiredService<DbContextOptions<ProductInventoryDbContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   
                }

                context.Products.AddRange(
                     new ProductInventory { Name = "lettuce", Price = 10.5, Quantity = 50, Type = "Leafy green" },
                     new ProductInventory { Name = "cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" },
                     new ProductInventory { Name = "pumpkin", Price = 30, Quantity = 30, Type = "Marrow" },
                     new ProductInventory { Name = "cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" },
                     new ProductInventory { Name = "zucchini", Price = 20.5, Quantity = 50, Type = "Marrow" },
                     new ProductInventory { Name = "spinach", Price = 10, Quantity = 100, Type = "Leafy green" },
                     new ProductInventory { Name = "yam", Price = 30, Quantity = 50, Type = "Root" },
                     new ProductInventory { Name = "broccoli", Price = 20.5, Quantity = 75, Type = "Cruciferous" },
                     new ProductInventory { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy green" },
                     new ProductInventory { Name = "silverbeet", Price = 10, Quantity = 50, Type = "Marrow" }
                );
                context.SaveChanges();
            }
        }

        }
}
