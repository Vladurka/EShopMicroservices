using Discount.Grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data;

public class DiscountContext : DbContext
{
    public DbSet<Coupon> Coupons { get; set; }
    
    public DiscountContext(DbContextOptions<DiscountContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon(id: 1, name: "IPhone X", description: "IPhone Discount", amount: 150),
            new Coupon(id: 2, name: "Samsung 10", description: "Samsung Discount", amount: 100));
    }
}