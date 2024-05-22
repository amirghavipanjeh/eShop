using Shop.Catalog.Domain.Base;
using Shop.Catalog.Domain.Categories.ValueObjects;
using Shop.Catalog.Domain.ParentCategories;
using System.ComponentModel.DataAnnotations;

namespace Shop.Catalog.Domain.Categories
{
    public class Category : AggregateRoot<long>
    {
        public Name Name { get; set; }
        public Description? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        // Foreign key
        public long ParentCategoryId { get; set; }

        // Navigation property
        public ParentCategory ParentCategory { get; set; }

       
    }
}

