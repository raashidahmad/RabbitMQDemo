using Microsoft.EntityFrameworkCore;
using RabbitMQDemo.Models;

namespace RabbitMQDemo.DB
{
    public class ProductsDB : DbContext
    {
        protected readonly IConfiguration configuration = null;

        public ProductsDB(IConfiguration config)
        {
            configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
