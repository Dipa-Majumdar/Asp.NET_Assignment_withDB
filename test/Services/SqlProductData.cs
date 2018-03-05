﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data;
using test.Models;


namespace test.Services
{
    public class SqlProductData : IProductData
    {
        private ProductInventoryDbContext _context;

        public SqlProductData(ProductInventoryDbContext context)
        {
            _context = context;
        }

        public SqlProductData()
        {
        }

        public ProductInventory Add(ProductInventory newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

       
        private IActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProductInventory> IProductData.GetAll()
        {
           return _context.Products.OrderBy(r => r.Name);
        }

        public ProductInventory Update(string Name)
        {
            return _context.Products.FirstOrDefault(r => r.Name == Name);
        }

        void IProductData.DeleteProduct(string Name, int Id)
        {
           // var itemToDelete = _context.Products.Find(x => x.Id == Id);
           // _context.Products.Remove(itemToDelete);
            _context.SaveChanges();
        }

       

        ProductInventory IProductData.Update(string Name)
        {
            return _context.Products.FirstOrDefault(r => r.Name == Name);
        }

        ProductInventory IProductData.Add(ProductInventory newProduct)
        {
            throw new NotImplementedException();
        }
    }
}