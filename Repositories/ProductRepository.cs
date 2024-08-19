using ProductsCrudApi.Models;
using ProductsCrudApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductsCrudApi.Repositories
{
  public class ProductRepository : IProductRepository
  {
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<Product>> GetTaskAsync()
    {
      return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
      return await _context.FindAsync(id);
    }

    public async Task AddAsync(Product product)
    {
      await _context.Products.AddAsync(product);
      await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
      _context.Products.Update(product);
      await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
      var product = await _context.Product.FindAsync(id);
      if (product !== null)
      {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
      }
    }
  }
}