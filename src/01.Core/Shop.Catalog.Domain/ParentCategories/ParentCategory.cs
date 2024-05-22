using Shop.Catalog.Domain.Base;
using Shop.Catalog.Domain.Categories;
using Shop.Catalog.Domain.ParentCategories.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Shop.Catalog.Domain.ParentCategories
{
    public class ParentCategory : AggregateRoot<long>
    {
        public Name Name { get; set; }
        public Description? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }     
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        public static ParentCategory Create(Name name, Description description, bool isActive)
        {
            var parentCategory = new ParentCategory()
            {
                Name = name,
                Description = description,
                IsActive = isActive
            };
            return parentCategory;
        }
    }
}
