using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("9 Bugambilias", "Xalapa", "Veracruz", "Mexico");
        Customer customer1 = new Customer("Fernanda Amador", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Sketchbook", "S101", 7.50, 3));
        order1.AddProduct(new Product("Pencil Set", "S102", 4.00, 4));
        order1.AddProduct(new Product("Glue Stick", "S103", 2.50, 6));

        // Order 2
        Address address2 = new Address("25 Oak Street", "Phoenix", "Arizona", "USA");
        Customer customer2 = new Customer("Ryan Hillgendorf", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "S200", 3.50, 5));
        order2.AddProduct(new Product("Blue Pens", "S201", 1.25, 10));
        order2.AddProduct(new Product("Colored Markers", "S202", 8.75, 2));

        // Display Orders
        Console.WriteLine();
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        Console.WriteLine();
    }
}