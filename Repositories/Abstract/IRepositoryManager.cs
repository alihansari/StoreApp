namespace Repositories.Abstract
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}