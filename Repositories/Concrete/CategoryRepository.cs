using Entities.Models;
using Repositories.Abstract;

namespace Repositories.Concrete
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {

        }
    }
}