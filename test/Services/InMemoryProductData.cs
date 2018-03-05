using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Services
{
    public class InMemoryProductData : IProductData
    {
        public InMemoryProductData()
        {
            _products = new List<ProductInventory>
                {
                new ProductInventory() { Name = "lettuce", Price = 10.5, Quantity = 50, Type = "Leafy green" },
                new ProductInventory() { Name = "cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" },
                new ProductInventory() { Name = "pumpkin", Price = 30, Quantity = 30, Type = "Marrow" },
                new ProductInventory() { Name = "cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" },
                new ProductInventory() { Name = "zucchini", Price = 20.5, Quantity = 50, Type = "Marrow" },
                new ProductInventory() { Name = "spinach", Price = 10, Quantity = 100, Type = "Leafy green" },
                new ProductInventory() { Name = "yam", Price = 30, Quantity = 50, Type = "Root" },
                new ProductInventory() { Name = "broccoli", Price = 20.5, Quantity = 75, Type = "Cruciferous" },
                new ProductInventory() { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy green" },
                new ProductInventory() { Name = "silverbeet", Price = 10, Quantity = 50, Type = "Marrow" }

            };
        }
      

        public IEnumerable<ProductInventory> GetAll()
        {
            return _products.OrderBy(r=>r.Name);
        }

        public ProductInventory Update(string name)
        {
          
            return _products.FirstOrDefault(r => r.Name == name);
            
        }

        public ProductInventory Add(ProductInventory newProduct)
        {
            _products.Add(newProduct);
            return newProduct;
        }

        public void Delete(string name)
        {
            var itemToDelete = _products.Find(x => x.Name == name);
            _products.Remove(itemToDelete);
        }

        public void DeleteProduct(string Name,int Id)
        {
            var itemToDelete = _products.Find(x => x.Id == Id);
            _products.Remove(itemToDelete);
        }

        

        List<ProductInventory> _products;
    }
}
