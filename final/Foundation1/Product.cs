using System;

class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name { get { return name; } }
    public int ProductId { get { return productId; } }
    public double Price { get { return price * quantity; } }
}