using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Services
{
   public interface IProductData
    {
        IEnumerable<ProductInventory> GetAll();
        ProductInventory Update(int Id);
        ProductInventory Add(ProductInventory newProduct);
        void DeleteProduct(int id);
    }
   
}
