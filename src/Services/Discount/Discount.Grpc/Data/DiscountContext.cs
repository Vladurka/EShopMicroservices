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
            new Coupon(1, "IPhone X", "IPhone Discount", 150),
            new Coupon(2, "Samsung 10", "Samsung Discount", 100));
    }
}