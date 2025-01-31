namespace Discount.Grpc.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount { get; set; }

        private Coupon(){}

        public Coupon(int id, string name, string description, int amount)
        {
            Id = id;
            ProductName = name;
            Description = description;
            Amount = amount;
        }
        
        public Coupon(string name, string description, int amount)
        {
            ProductName = name;
            Description = description;
            Amount = amount;
        }
    }
}
