using System;
using System.Collections.Generic;
using System.Linq;
using LowPrice.API.Domain.Models;

namespace LowPrice.API.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly DataContext _context;

        public ProductRepo(DataContext context)
        {
            _context = context;
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
            return prod;
        }
        
    }
}