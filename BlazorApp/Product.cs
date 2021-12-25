using Microsoft.EntityFrameworkCore;

namespace BlazorApp;

[Index(nameof(Price))]
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public Product(string name, decimal price, string url, string description = "")
    {
        Name = name;
        Price = price;
        Url = url;
        Description = description;
    }
}

public enum Category
{
    Book,
    Rocket
}