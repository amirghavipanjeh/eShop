using Shop.Catalog.Domain.ParentCategories;
using Shop.Catalog.Persistence.EntityFramework;
using System.Linq.Expressions;

namespace Shop.Catalog.Domain.Contracts
{
    public interface IParentCategoryRepository : IBaseRepository<ParentCategory>
    {
        public bool IsExist(Expression<Func<ParentCategory, bool>> predicate);
        // Add any additional methods specific to ParentCategory if needed
    }
}
