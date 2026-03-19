namespace oppgave1;

public class Product
{
    // Properties of the product
    public string Name { get; set; } = "Unknown";
    public int Stock { get; set; }
    public double Price { get; set; }

    // Constructor to make it easier to create a product
    public Product(string name, int stock, double price)
    {
        Name = name;
        Stock = stock;
        Price = price;
    }
}