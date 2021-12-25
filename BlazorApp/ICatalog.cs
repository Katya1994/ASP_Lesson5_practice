namespace BlazorApp;

public interface ICatalog
{
    IDictionary<Category, List<Product>> GetProductList();
}