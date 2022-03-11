using System;

namespace LowPrice.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public DateTime Update{ get; set; }
    }
}