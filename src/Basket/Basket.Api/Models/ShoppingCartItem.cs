namespace Basket.Api.Models
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; } 
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public Guid ProductId { get; set; } = Guid.NewGuid();   
        public string ProductName { get; set; } = string.Empty;
    }
}
