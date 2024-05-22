using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Catalog.Domain.Categories;
using Shop.Catalog.Domain.ParentCategories;
using System.Data;

namespace Shop.Catalog.Persistence.EntityFramework.ParentCategories.EntityConfigurations
{
    public class ParentCategoryConfigurations : IEntityTypeConfiguration<ParentCategory>
    {
        public void Configure(EntityTypeBuilder<ParentCategory> builder)
        {
            builder.ToTable(nameof(ParentCategory), Schema.Catalog);
            builder.HasKey(x => x.Id);
            builder.Property(pc => pc.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.RowVersion)
               .IsRowVersion();

            builder.OwnsOne(p => p.Name, m =>
            {
                m.Property(x => x.Value)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(200)
                .HasColumnName(nameof(ParentCategory.Name));
            });

            builder.OwnsOne(p => p.Description, m =>
            {
                m.Property(x => x.Value)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(4000)
                .HasColumnName(nameof(ParentCategory.Description));
            });


            builder.HasMany(pc => pc.Categories)
               .WithOne(c => c.ParentCategory)
               .HasForeignKey(c => c.ParentCategoryId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
