namespace Ordering.Infrastructure.Data.Extensions;
internal class InitialData
{
    public static IEnumerable<Customer> Customers =>
    new List<Customer>
    {
        Customer.Create(CustomerId.Of(Guid.NewGuid()), "mehmet", "mehmet@gmail.com"),
        Customer.Create(CustomerId.Of(Guid.NewGuid()), "john", "john@gmail.com")
    };

    public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(ProductId.Of(Guid.NewGuid()), "IPhone X", 500),
            Product.Create(ProductId.Of(Guid.NewGuid()), "Samsung 10", 400),
            Product.Create(ProductId.Of(Guid.NewGuid()), "Huawei Plus", 650),
            Product.Create(ProductId.Of(Guid.NewGuid()), "Xiaomi Mi", 450)
        };

    public static IEnumerable<Order> OrdersWithItems
    {
        get
        {
            var address1 = Address.Of("mehmet", "ozkaya", "mehmet@gmail.com", "Bahcelievler No:4", "Turkey", "Istanbul", "38050");
            var address2 = Address.Of("john", "doe", "john@gmail.com", "Broadway No:1", "England", "Nottingham", "08050");

            var payment1 = Payment.Of("mehmet", "5555555555554444", "12/28", "355", 1);
            var payment2 = Payment.Of("john", "8885555555554444", "06/30", "222", 2);

            var order1 = Order.Create(
                            OrderId.Of(Guid.NewGuid()),
                            CustomerId.Of(Guid.NewGuid()),
                            OrderName.Of("ORD_1"),
                            shippingAddress: address1,
                            billingAddress: address1,
                            payment1);
            order1.Add(ProductId.Of(Guid.NewGuid()), 2, 500);
            order1.Add(ProductId.Of(Guid.NewGuid()), 1, 400);

            var order2 = Order.Create(
                            OrderId.Of(Guid.NewGuid()),
                            CustomerId.Of(Guid.NewGuid()),
                            OrderName.Of("ORD_2"),
                            shippingAddress: address2,
                            billingAddress: address2,
                            payment2);
            order2.Add(ProductId.Of(Guid.NewGuid()), 1, 650);
            order2.Add(ProductId.Of(Guid.NewGuid()), 2, 450);

            return new List<Order> { order1, order2 };
        }
    }
}