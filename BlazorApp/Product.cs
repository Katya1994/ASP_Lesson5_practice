namespace BlazorApp;

public class Product
{
    public Guid Id { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public string Url { get; set; }
    public Product(string author, decimal price, string url)
    {
        Author = author;
        Price = price;
        Url = url;
    }
}