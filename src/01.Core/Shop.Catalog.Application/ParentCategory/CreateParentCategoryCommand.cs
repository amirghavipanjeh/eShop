using MediatR;
using System.Windows.Input;

namespace Shop.Catalog.Application.Contracts.ParentCategory
{
    public class CreateParentCategoryCommand : IRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
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
