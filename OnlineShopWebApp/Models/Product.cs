namespace OnlineShopWebApp.Models
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product(string name, decimal cost, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
