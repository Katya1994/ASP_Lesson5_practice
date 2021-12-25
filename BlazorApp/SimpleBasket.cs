namespace BlazorApp;

public class SimpleBasket: IBasket
{
    private Dictionary<Product, int> basketProducts = new Dictionary<Product, int>();
    private object locker = new object();
        
    public void AddToBasket(Product product)
    {
        lock (locker)
        {
            if (basketProducts.ContainsKey(product))
                basketProducts[product]++;
            else
                basketProducts.Add(product, 1);
        }
    }

    public Dictionary<Product, int> GetBasketProducts()
    {
        return basketProducts;
    }

    public void ClearBasket()
    {
        lock (locker)
        {
            basketProducts.Clear();
        }
    }

    public void DeleteProduct(Product product)
    {
        lock (locker)
        {
            basketProducts.Remove(product);
        }
    }
}