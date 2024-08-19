using ProductsCrudApi.Models;

namespace ProductsCrudApi.Services
{
  public interface IProductService
  {
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
  }
}