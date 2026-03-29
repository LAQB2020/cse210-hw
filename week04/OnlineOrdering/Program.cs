using System;
class Program
{
    static void Main(string[] args)
    {
        //Customer Definition
        Address a1 = new Address("742 Evergreen Terrace","Springfield","IL","USA");
        Customer c1 =new Customer("Luis Quezada",a1);
        //Products definition
        Product p1 = new Product("Wireless Bluetooth Headphones", "T1001", 79.99, 1);
        Product p2 = new Product("Smartphone 128GB", "T1002", 699.00, 1);
        Product p3 = new Product("Mechanical Keyboard", "T1003", 129.50, 1);
        Product p4 = new Product("Wireless Mouse", "T1004", 39.99, 2);
        Product p5 = new Product("Smartwatch", "T1005", 249.99, 1);
        //Order Definition
        Order o1 = new Order();
        o1.SetCustomer(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);
        o1.AddProduct(p5);
        //Print Results
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine($"Total cost: {o1.CopmuteTotalCost()}\n");
        Console.WriteLine(o1.GetShippingLabel());    
    }
}