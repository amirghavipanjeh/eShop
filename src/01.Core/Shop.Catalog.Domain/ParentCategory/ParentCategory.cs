using Shop.Catalog.Domain.ParentCategory.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Domain.ParentCategory
{
    public class ParentCategory : AggregateRoot<long>
    {
        public long Id { get; set; }
        public Name Name { get; set; }
        public Description Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public List<CreateCategoryCommand> Categories { get; set; } = new List<CreateCategoryCommand>();

        // Constructor with input parameters
        public CreateParentCategoryCommand(long id, string name, string? description, string? imageUrl, bool isActive, List<CreateCategoryCommand> categories)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            ImageUrl = imageUrl;
            IsActive = isActive;
            Categories = categories ?? throw new ArgumentNullException(nameof(categories));
        }
    }
}
