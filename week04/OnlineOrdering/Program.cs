using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Smith", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Laptop", "P001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P002", 20, 2));

        // Order 2 (International)
        Address addr2 = new Address("45 Mtaa Rd", "Dar es Salaam", "", "Tanzania");
        Customer cust2 = new Customer("Ema", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Phone", "P003", 500, 1));
        order2.AddProduct(new Product("Charger", "P004", 25, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}