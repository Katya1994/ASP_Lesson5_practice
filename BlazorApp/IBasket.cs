namespace BlazorApp;

public interface IBasket
{
    public void AddToBasket(Product product);
    public Dictionary<Product, int> GetBasketProducts();
    public void ClearBasket();
    public void DeleteProduct(Product product);
}