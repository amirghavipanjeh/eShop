using Microsoft.EntityFrameworkCore;
using Shop.Catalog.Domain.Contracts;
using Shop.Catalog.Domain.ParentCategories;
using System.Linq.Expressions;

namespace Shop.Catalog.Persistence.EntityFramework.ParentCategories
{
    public class ParentCategoryRepository : BaseRepository<ParentCategory>, IParentCategoryRepository
    {
        private DbSet<ParentCategory> _parentCategories;
        public ParentCategoryRepository(CatalogDbContext context) : base(context)
        {
            _parentCategories = context.Set<ParentCategory>();  
        }
        public bool IsExist(Expression<Func<ParentCategory, bool>> predicate)
        {
            return _parentCategories.FirstOrDefault(predicate) != null;
        }
        // Implement additional methods specific to ParentCategory if needed
    }
}
