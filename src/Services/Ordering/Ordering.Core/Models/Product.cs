namespace Ordering.Core.Models;

public class Product : Entity<ProductId>
{
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; } = decimal.Zero;
    
    public static Product Create(ProductId id, string name, decimal price)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        var product = new Product
        {
            Id = id,
            Name = name,
            Price = price
        };

        return product;
    }
}