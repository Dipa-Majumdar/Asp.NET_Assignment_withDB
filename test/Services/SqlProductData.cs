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

        public ProductInventory Update(int Id)
        {
            return _context.Products.Where(r => r.Id == Id).FirstOrDefault();
        }

        void IProductData.DeleteProduct(int Id)
        {
            var itemToDelete = _context.Products.Where(r => r.Id == Id).FirstOrDefault();

            if (itemToDelete != null)
            {
                _context.Products.Remove(itemToDelete);
            }
            _context.SaveChanges();
        }



        ProductInventory IProductData.Update(int Id)
        {
            return _context.Products.Where(r => r.Id == Id).FirstOrDefault();
        }

        ProductInventory IProductData.Add(ProductInventory newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }
    }
}
