using foodstore.api.data.Models;
using Microsoft.EntityFrameworkCore;

namespace foodstore.api.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Household> Households { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<ProductCategoryLink> ProductCategoryLink { get; set; }
        public DbSet<ProductNutrientLink> ProductNutrientLink { get; set; }
        public DbSet<UserHouseholdLink> UserHouseholdLink { get; set; }
    }
}