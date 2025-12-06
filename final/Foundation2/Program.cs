using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("214 Treadle Lane", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Perseus", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Textbook", "C# Programming", 59.99, 2));
        order1.AddProduct(new Product("Laptop", "Dell XPS 13", 999.99, 1));

        Console.WriteLine($"Order 1 Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Order 1 Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Order 1 Total Price: ${order1.GetPrice():F2}\n");

        Address address2 = new Address("223 S 5th W", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("John", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Clorox", "Cleaning Supplies", 12.49, 4));
        order2.AddProduct(new Product("Vacuum Cleaner", "Dyson V11", 599.99, 1));

        Console.WriteLine($"Order 2 Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Order 2 Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Order 2 Total Price: ${order2.GetPrice():F2}\n");
    }
}
