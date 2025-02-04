using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Infrastructure.Data;

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration config)
        {
            var connectionString = config.GetConnectionString("Database");

            services.AddDbContext<OrderingDbContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }
    }
}
