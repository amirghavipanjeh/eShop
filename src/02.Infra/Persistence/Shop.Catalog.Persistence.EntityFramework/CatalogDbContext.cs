using Microsoft.EntityFrameworkCore;
using Shop.Catalog.Domain.Categories;
using Shop.Catalog.Domain.ParentCategories;
using Shop.Catalog.Persistence.EntityFramework.Categories.EntityConfigurations;
using Shop.Catalog.Persistence.EntityFramework.ParentCategories.EntityConfigurations;

namespace Shop.Catalog.Persistence.EntityFramework
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        {

        }
        public DbSet<ParentCategory> ParentCategories { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParentCategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
