using System;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Hair Brush", "123", 10.99, 3);
        Product product2 = new Product("Samsung Smart Watch", "456", 25.49, 2);

        // Create customer
        Address customerAddress = new Address("41 Pemba Road", "Lusaka", "Lusaka", "Zambia");
        Customer customer = new Customer("Thelma Mak", customerAddress);

        // Create order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display order details
        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
    }
}