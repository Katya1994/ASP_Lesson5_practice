namespace WebApplication.Properties;

public class ICatalog
{
    public IList<Product> list;

    public ICatalog()
    {
        list = new List<Product>()
        {
            new Product("Стивен Кинг"),
            new Product("Борис Акунин"),
            new Product("Михаил Булгаков")
        };
    }
}