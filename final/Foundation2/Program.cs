using System;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("T-Shirt", "TS001", 18.00, 2);
        Product product2 = new Product("Jeans", "JN002", 49.30, 1);
        Product product3 = new Product("Shoes", "SH003", 55.00, 1);
        Product product4 = new Product("Hat", "HT004", 14.50, 3);
        Product product5 = new Product("Watch", "WT001", 20, 1);


        // Create addresses and customers
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine("----------------");
        Console.WriteLine("Order 1:");
        Console.WriteLine("----------------");
        Console.WriteLine("Packing:");
        Console.WriteLine("============");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping:");
        Console.WriteLine("============");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("----------------");
        Console.WriteLine("Order 2:");
        Console.WriteLine("----------------");
        Console.WriteLine("Packing:");
        Console.WriteLine("============");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping:");
        Console.WriteLine("============");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}