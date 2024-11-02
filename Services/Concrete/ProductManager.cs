using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Abstract;
using Services.Abstract;

namespace Services.Concrete;
public class ProductManager : IProductService
{
    private readonly IRepositoryManager _manager;
    private readonly IMapper _mapper;

    public ProductManager(IRepositoryManager manager, IMapper mapper)
    {
        _manager = manager;
        _mapper = mapper;
    }

    public void CreateProduct(ProductDtoForInsertion productDto)
    {
        Product product = _mapper.Map<Product>(productDto);
        _manager.Product.Create(product);
        _manager.Save();
    }

    public void DeleteProduct(int id)
    {
        var product = GetOneProduct(id, false);
        if (product is not null)
        {
            _manager.Product.DeleteProduct(product);
            _manager.Save();
        }
    }

    public IEnumerable<Product> GetAllProducts(bool trackChanges)
    {
        return _manager.Product.GetAllProducts(trackChanges);
    }

    public IEnumerable<Product> GetAllProductWithDetails(ProductRequestParameters p)
    {
        return _manager.Product.GetAllProductWithDetails(p);
    }

    public IEnumerable<Product> GetLastestProducts(int n, bool trackChanges)
    {
        return _manager.Product
            .FindAll(trackChanges)
            .OrderByDescending(prd => prd.Id)
            .Take(n);
    }

    public Product? GetOneProduct(int id, bool trackChanges)
    {
        var product = _manager.Product.GetProduct(id, trackChanges) ?? throw new Exception("Product not Found!");
        return product;
    }

    public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
    {
        var product = GetOneProduct(id, trackChanges);
        return _mapper.Map<ProductDtoForUpdate>(product);
    }

    public IEnumerable<Product> GetShowCaseProducts(bool trackChanges)
    {
        var products = _manager.Product.GetShowCaseProducts(trackChanges);
        return products;
    }

    public void UpdateProduct(ProductDtoForUpdate productDto)
    {
        var entity = _mapper.Map<Product>(productDto);
        _manager.Product.UpdateOneProduct(entity);
        _manager.Save();
    }
}
