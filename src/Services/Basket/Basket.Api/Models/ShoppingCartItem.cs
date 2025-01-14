namespace Basket.Api.Models
{
    public class ShoppingCartItem
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } 
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public string ProductName { get; set; } = string.Empty;

        public ShoppingCartItem(Guid productId, int quantity, string color, decimal price, string productName)
        {
            ProductId = productId;
            Quantity = quantity;
            Color = color;
            Price = price;
            ProductName = productName;
        }
        public ShoppingCartItem() { }
    }
}
