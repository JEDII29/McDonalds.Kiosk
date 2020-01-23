namespace McDonalds.Kiosk.Core.Models
{
    public class Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
    }
}
