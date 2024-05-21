namespace Shop.API.Controllers.ParentCategory.Models
{
    public class CreateParentCategory
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation property for the related categories
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        // Method to convert to a command or DTO if needed
        internal CreateParentCategoryCommand ToCommand()
        {
            return new CreateParentCategoryCommand
            {
                Id = Id,
                Name = Name,
                Description = Description,
                ImageUrl = ImageUrl,
                IsActive = IsActive,
                Categories = Categories.Select(c => c.ToCommand()).ToList()
            };
        }
    }
}
