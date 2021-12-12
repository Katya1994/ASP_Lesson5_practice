namespace BlazorApp;

public interface ICatalog
{
    IList<Product> List { get; set; }
}