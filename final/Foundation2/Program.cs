using System;

class Program
{
    static void Main(string[] args)
    {
        //Order #1
        Order order = new Order("Ashlee Hart", "1895 Larkflower Way", "Lincoln", "CA", 95630, "USA");
        Console.WriteLine("Online Ordering");
        Console.WriteLine("==================================");
        Console.WriteLine();
        Console.WriteLine("ORDER 1:");
        Console.WriteLine();
        Address address1 = new Address("1895 Larkflower Way", "Lincoln", "CA", 95630, "USA");
        //Product product1 = new Product("", 0, 0, 0);
        //Display the first order
        order.ListOrder1();
        //Show the cost and labels
        Console.WriteLine("==================================");
        order.TotalCost();
        order.ShippingCost();
        order.PackingLabel();
        order.ShippingLabel();

        //Order #2
        Order order2 = new Order("Rachel Hart", "266 W 3rd S", "Rexburg", "ID", 83440, "USA");
        Console.WriteLine("==================================");
        Console.WriteLine();
        Console.WriteLine("ORDER 2:");
        Console.WriteLine();
        Address address2 = new Address("266 W 3rd S", "Rexburg", "ID", 83440, "USA");
        order2.ListOrder2();
        //Show the cost and labels
        Console.WriteLine("==================================");
        order2.TotalCost();
        order2.ShippingCost();
        order2.PackingLabel();
        order2.ShippingLabel();
    }
    
}