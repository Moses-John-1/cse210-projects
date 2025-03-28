using System;

class Program
{
    static void Main(string[] args)
    {
       // addresses
        Address address1 = new Address("123 Wall Street", "New York", "NY", "USA");
        Address address2 = new Address("456 King Street", "Toronto", "Ontario", "Canada");

        // customer's details
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Alice Smith", address2);

        // Here orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 899.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM456", 29.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HP789", 199.99, 1));
        order2.AddProduct(new Product("Keyboard", "KB101", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "MN202", 299.99, 1));

        // Here order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}