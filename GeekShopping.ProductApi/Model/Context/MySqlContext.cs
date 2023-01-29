using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Model.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MySqlContext() {}
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {} 

    }
}
