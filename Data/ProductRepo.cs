using System;
using System.Collections.Generic;
using System.Linq;
using LowPrice.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LowPrice.API.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly DataContext _context;

        public ProductRepo(DataContext context)
        {
            _context = context;
        }

        public bool DeleteProduct(int id)
        {
            try{
                Product product = new Product(){Id = id};
                _context.Products.Attach(product);
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }catch(DbUpdateConcurrencyException){
                return false;
            }
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product InsertProduct(Product product){
            var prod = _context.Products.Add(product).Entity;
            _context.SaveChanges();
            return prod;
        }
        
    }
}