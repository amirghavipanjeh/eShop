using MediatR;
using Shop.Catalog.Application.Contracts.ParentCategory;
using Shop.Catalog.Domain.Contract;
using Shop.Catalog.Domain.Contracts;
using Shop.Catalog.Domain.ParentCategories.ValueObjects;

namespace Shop.Catalog.Application.ParentCategory
{
    internal class CreateParentCategoryCommandHandler : IRequestHandler<CreateParentCategoryCommand, CreateParentCategoryResponse>
    {
        private readonly IParentCategoryRepository _context;
        public CreateParentCategoryCommandHandler(IParentCategoryRepository context) : base()
        {
            _context = context;

        }

        public async Task<CreateParentCategoryResponse> Handle(CreateParentCategoryCommand request, CancellationToken cancellationToken)
        {
            var name = new Name(request.Name);
            var description = new Description(request.Description);
            var parentCategory = Domain.ParentCategories.ParentCategory.Create(name, description, true);
            await _context.AddAsync(parentCategory);

            var parentCategoryResponce = new CreateParentCategoryResponse()
            {
                Id = parentCategory.Id,
                Name = parentCategory.Name.ToString(),
                Description = parentCategory.Description.ToString(),
                IsActive = parentCategory.IsActive

            };
            return parentCategoryResponce;
        }
    }
}
