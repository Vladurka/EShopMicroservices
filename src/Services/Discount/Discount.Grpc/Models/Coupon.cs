namespace Discount.Grpc.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount;

        private Coupon(){}

        public Coupon(int id, string name, string description, int amount)
        {
            Id = id;
            Name = name;
            Description = description;
            Amount = amount;
        }
        
        public Coupon(string name, string description, int amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }
    }
}
