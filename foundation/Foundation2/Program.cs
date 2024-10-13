using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("154 Park Street", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Kaladin Stormblessed", address1);
        Product product1 = new Product("Spear", "66", 10.95, 1);
        Product product2 = new Product("Gemstone", "7895", 29.99, 10);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("Auf der Stift 3", "Vienna", "Innere Stadt", "Austria");
        Customer customer2 = new Customer("Deine Mutter", address2);
        Product product3 = new Product("Lederhosen", "32196", 99.99, 1);
        Product product4 = new Product("Dirndl", "78961", 89.99, 1);
        Product product5 = new Product("Schnitzel", "7895", 4.99, 10);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Corrected method calls
        Console.WriteLine(order1.GenerateOrderSummary()); 
        Console.WriteLine("Shipping cost: " + order1.ShippingCost());
        Console.WriteLine("Total cost: " + order1.GetTotalCost());

        Console.WriteLine("\n\n");
        Console.WriteLine(order2.GenerateOrderSummary()); 
        Console.WriteLine("Shipping cost: " + order2.ShippingCost()); 
        Console.WriteLine("Total cost: " + order2.GetTotalCost()); 
    }
}
