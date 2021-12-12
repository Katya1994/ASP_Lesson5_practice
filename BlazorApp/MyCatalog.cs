namespace BlazorApp;

public class MyCatalog: ICatalog
{
    public IList<Product> List { get; set; } = new List<Product>()
    {
        new Product("Стивен Кинг", 1500, "https://img4.labirint.ru/rc/2f7d48ee73c87a4d16e8385b1a0d413b/220x340/books69/683432/cover.jpg?1564173848"),
        new Product("Борис Акунин", 1400, "https://img4.labirint.ru/rc/72e9df791abc65b7421717b99f880206/220x340/books76/754834/cover.jpg?1597847102"),
        new Product("Михаил Булгаков", 999, "https://img4.labirint.ru/rc/be52f38894b280fb49d5c6c7ef390287/220x340/books25/244606/cover.jpg?1472463171")
    };
}