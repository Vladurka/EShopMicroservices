namespace Basket.Api.Models
{
    public class ShoppingCart
    {
        public string UserName { get; set; } = string.Empty;
        public IEnumerable<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public ShoppingCart(){ }
    }
}
