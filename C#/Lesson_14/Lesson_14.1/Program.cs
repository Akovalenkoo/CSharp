using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Shop
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        Product productToRemove = products.Find(p => p.Id == productId);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
        }
    }

    public Product GetProductById(int productId)
    {
        return products.Find(p => p.Id == productId);
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }
}

class Cart
{
    private List<Product> cartItems = new List<Product>();

    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    public void RemoveFromCart(int productId)
    {
        Product productToRemove = cartItems.Find(p => p.Id == productId);
        if (productToRemove != null)
        {
            cartItems.Remove(productToRemove);
        }
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product item in cartItems)
        {
            totalPrice += item.Price;
        }
        return totalPrice;
    }

    public List<Product> GetAllCartItems()
    {
        return cartItems;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        Product product1 = new Product { Id = 1, Name = "Product A", Price = 10.0 };
        Product product2 = new Product { Id = 2, Name = "Product B", Price = 15.0 };
        Product product3 = new Product { Id = 3, Name = "Product C", Price = 20.0 };

        shop.AddProduct(product1);
        shop.AddProduct(product2);
        shop.AddProduct(product3);

        Cart cart = new Cart();

        cart.AddToCart(product1);
        cart.AddToCart(product2);

        Console.WriteLine("Available Products in the Shop:");
        foreach (Product product in shop.GetAllProducts())
        {
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        }

        Console.WriteLine("\nItems in the Cart:");
        foreach (Product product in cart.GetAllCartItems())
        {
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        }

        double totalPrice = cart.GetTotalPrice();
        Console.WriteLine($"\nTotal Price in the Cart: {totalPrice:C}");

        Console.ReadLine(); 
    }
}




