using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Pages;

public interface IProductRepository
{
    Task<Product> GetById(Guid Id);
    Task Add(Product product);
    Task Update(Product product);
    Task<List<Product>> GetProductList();
}

public class ProductRepository: IProductRepository
{
    private readonly AppDbContext _dbContext;
    //логгер
    private readonly ILogger<ProductRepository> _logger;

    public ProductRepository(AppDbContext dbContext, ILogger<ProductRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
        _logger.LogInformation("OrderRepository has been created");
    }

    public Task<Product> GetById(Guid Id)
    {
        _logger.LogWarning("Get Product by Id: {Product id}", Id);
        return _dbContext.Orders.FirstAsync(it => it.Id == Id);
    }

    public async Task Add(Product product)
    {
        _logger.LogWarning("Adding order with Id: {ProductId}", product.Id);
        await _dbContext.Orders.AddAsync(product);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(Product product)
    {
        _logger.LogWarning("Updating {Product Name}", product.Name);
        _dbContext.Entry(product).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<List<Product>> GetProductList()
    {
        return _dbContext.Orders.ToList();
    }
}