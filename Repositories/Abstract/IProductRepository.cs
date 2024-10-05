using Entities.Models;
using Entities.RequestParameters;

namespace Repositories.Abstract
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        IQueryable<Product> GetAllProductWithDetails(ProductRequestParameters p);
        IQueryable<Product> GetShowCaseProducts(bool trackChanges);
        Product? GetProduct(int id, bool trackChanges);
        void CreateProduct(Product product);
        void DeleteProduct(Product product);
        void UpdateOneProduct(Product entity);
    }
}