using ProductsCrudApi.Models;
using ProductsCrudApi.Repositories;

namespace ProductsCrudApi.Services
{
  public class ProductService : IProductService
  {
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
      return await _productRepository.GetAllAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
      return await _productRepository.GetProductById(id);
    }

    public async Task AddProductAsync(Product product)
    {
      await _productRepository.AddAsync(product);
    }

    public async Task UpdateProductAsync(Product product)
    {
      await _productRepository.UpdateAsync(product);
    }

    public async Task DeleteProductAsync(int id)
    {
      await _productRepository.DeleteAsync(id);
    }
  }
}