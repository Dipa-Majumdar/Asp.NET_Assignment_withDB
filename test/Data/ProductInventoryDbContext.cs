
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

using Microsoft.EntityFrameworkCore;
using test.ViewModels;

namespace test.Data
{
    public class ProductInventoryDbContext : DbContext
    {
        public  DbSet<ProductInventory> Products { get; set; }

        public ProductInventoryDbContext(DbContextOptions options) : base(options)
        {

        }
       

    }
}
