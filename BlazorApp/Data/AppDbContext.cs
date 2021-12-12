namespace BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    public DbSet<Product> Orders => Set<Product>();

    public AppDbContext(
        DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }

}