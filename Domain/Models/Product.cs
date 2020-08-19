namespace LowPrice.API.Domain.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public Type Type { get; set; }
        public double Price { get; set; }
        public string Update{ get; set; }

    }
}