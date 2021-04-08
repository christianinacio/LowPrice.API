namespace LowPrice.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Type { get; set; }
        public double Price { get; set; }
        public string Update{ get; set; }

    }
}