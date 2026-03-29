using System.Diagnostics.Contracts;
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    public Product()
    {
        _name = "Milk";
        _productId = "AAA";
        _price = 0;
        _quantity = 0;
    }
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    //Getters and setters
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public double GetPrice()
    {
        return _price;
    }
      public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double GetQuantity()
    {
        return _quantity;
    }
    //Methods
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}