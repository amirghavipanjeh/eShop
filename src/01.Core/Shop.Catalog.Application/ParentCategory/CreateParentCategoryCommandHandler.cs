using MediatR;
using Shop.Catalog.Application.Contracts.ParentCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Application.ParentCategory
{
    internal class CreateParentCategoryCommandHandler : IRequestHandler<CreateParentCategoryCommand>
    {
        public Task Handle(CreateParentCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
