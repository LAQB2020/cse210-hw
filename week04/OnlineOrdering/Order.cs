public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order()
    {
        _products = new List<Product>();
        _customer = new Customer();
    }
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    //Getters and Setters
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
         _customer = customer;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProducts(List<Product> products)
    {
         _products = products;
    }
    //Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CopmuteTotalCost()
    {
        double totalCost=0;
        double totalPrice=0;
        foreach (var product in _products)
        {
            totalPrice = totalPrice + (product.GetPrice() * product.GetQuantity());
        }
        if(_customer.LiveInUsa() == true )
        {
            totalCost = totalPrice + 5;
        }
        else
        {
            totalCost = totalPrice + 35;
        }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (var product in _products)
        {
            packingLabel += product.GetName() + ", " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
       return _customer.GetCustomerName() + "\n" + _customer.GetCustomerAddress().FullAdress();
    }   
}