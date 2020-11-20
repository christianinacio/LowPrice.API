using System.Collections.Generic;
using LowPrice.API.Domain.Models;

namespace LowPrice.API.Data
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(string id);
        Product InsertProduct(Product product);
    }
}