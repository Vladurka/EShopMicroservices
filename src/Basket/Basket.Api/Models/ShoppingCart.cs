namespace Basket.Api.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public IEnumerable<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);

        public ShoppingCart(Guid id)
        {
            Id = id;
        }

        public ShoppingCart(){ }
    }
}
