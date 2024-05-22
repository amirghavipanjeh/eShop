using Shop.Catalog.Application.Contracts.ParentCategory;

namespace Shop.API.Controllers.ParentCategory.Models
{
    public class CreateParentCategoryModel
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation property for the related categories
        //    public ICollection<Category> Categories { get; set; } = new List<Category>();

        // Method to convert to a command or DTO if needed
        //internal CreateParentCategoryCommand ToCommand()
        //{
        //    return new CreateParentCategoryCommand(Name, Description, ImageUrl, IsActive);
        //}



    }
}
