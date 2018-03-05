using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Database
    {
        List<ProductInventory> product_list = new List<ProductInventory>();
        public List<ProductInventory> GetProductList()
        {
            product_list.Add((new ProductInventory() { Name = "lettuce", Price = 10.5, Quantity = 50, Type = "Leafy green" }));
            product_list.Add(new ProductInventory() { Name = "cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" });
            product_list.Add(new ProductInventory() { Name = "pumpkin", Price = 30, Quantity = 30, Type = "Marrow" });
            product_list.Add(new ProductInventory() { Name = "cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" });
            product_list.Add(new ProductInventory() { Name = "zucchini", Price = 20.5, Quantity = 50, Type = "Marrow" });
            product_list.Add(new ProductInventory() { Name = "spinach", Price = 10, Quantity = 100, Type = "Leafy green" });
            product_list.Add(new ProductInventory() { Name = "yam", Price = 30, Quantity = 50, Type = "Root" });
            product_list.Add(new ProductInventory() { Name = "broccoli", Price = 20.5, Quantity = 75, Type = "Cruciferous" });
            product_list.Add(new ProductInventory() { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy green" });
            product_list.Add(new ProductInventory() { Name = "silverbeet", Price = 10, Quantity = 50, Type = "Marrow" });

            return product_list;
        }
       
        


    }
}
