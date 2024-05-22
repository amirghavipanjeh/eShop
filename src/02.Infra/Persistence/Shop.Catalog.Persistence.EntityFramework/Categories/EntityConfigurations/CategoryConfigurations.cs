using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Catalog.Domain.Categories;
using Shop.Catalog.Domain.ParentCategories;
using System.Data;

namespace Shop.Catalog.Persistence.EntityFramework.Categories.EntityConfigurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>

    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category), Schema.Catalog);
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.RowVersion)
                .IsRowVersion();


            builder.OwnsOne(p => p.Name, m =>
            {
                m.Property(x => x.Value)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(200)
                .HasColumnName(nameof(Category.Name));
            });

            builder.OwnsOne(p => p.Description, m =>
            {
                m.Property(x => x.Value)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(4000)
                .HasColumnName(nameof(Category.Description));
            });

            // Configure the foreign key relationship
            builder.HasOne(c => c.ParentCategory)
                   .WithMany(pc => pc.Categories)
                   .HasForeignKey(c => c.ParentCategoryId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
