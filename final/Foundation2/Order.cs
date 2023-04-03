using System;

class Order 
{
    Address _address;
    Customer _customerName;

    public List<Product> products;
    public int _shippingCost;
    // List<string> _listOrder = new List<string> 
    // {
    //     " ", " "
    // };
    public Order(string name, string streetAddress, string city, string state, int zip, string country) 
    {
        _address = new Address(streetAddress, city, state, zip, country);
        _customerName = new Customer(name);
    }
    public void AddProduct(string productName, int id, double price, int quantity)
    {
        Product newProduct = new Product(productName, id, price, quantity);
        products.Add(newProduct);
    }

    public void ListOrder1()
    {
        products = new List<Product>();
        products.Add(new Product("MongoKiss Strawberry Lip Balm 3 Pack", 20065, 12.89, 1));
        products.Add(new Product("Daily Planner Undated, 160 Pages", 20134, 13.99, 1));
        products.Add(new Product("Fleece Belt Bag for Women", 10089, 17.82, 1));
        foreach (Product p in products)
        {
            Console.WriteLine($"Product Name: " + p.GetName());
            Console.WriteLine($"Qty: " + p.GetQuantity());
            Console.WriteLine($"Price: ${p.GetPrice()}");
            Console.WriteLine();
        }
    }
    public void ListOrder2()
    {
        products = new List<Product>();
        products.Add(new Product("Silk Satin Sleeping Mask", 30087, 9.29, 2));
        products.Add(new Product("The Power of Now: A Guide to Spiritual Enlightenment", 802465, 8.89, 1));
        products.Add(new Product("Hardshell White Clutch Purse for Women", 30724, 29.99, 1));
        foreach (Product p in products)
        {
            Console.WriteLine($"Product Name: " + p.GetName());
            Console.WriteLine($"Qty: " + p.GetQuantity());
            Console.WriteLine($"Price: ${p.GetPrice()}");
            Console.WriteLine();
        }
    }

    public double TotalCost()
    {
        double subtotal = 0;
        foreach (Product p in products)
        {
            subtotal += p.GetPrice();
        }
        return subtotal;
    }
    public string ShippingCost()
    {
        return "Shipping Cost: $" + _address.USA();
    }
    public void PackingLabel()
    {
        Console.WriteLine("Palm Love Boutique");
        Console.WriteLine();
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine();
        Console.WriteLine("ITEMS IN ORDER:");
        Console.WriteLine("____________________________________");
        Console.WriteLine("");
        foreach(Product p in products)
        {
            //might be products instead of p
            Console.WriteLine($"Product: " + p.GetName());
            Console.WriteLine($"ID: " + p.GetProductID());
            Console.WriteLine();
        }
        Console.WriteLine($"TOTAL: ${TotalCost()}");
        Console.WriteLine($"{ShippingCost()}");
        Console.WriteLine("____________________________________");
        Console.WriteLine("");
    }
    public void ShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("==================================");
        Console.WriteLine("TO: ");
        Console.WriteLine(_customerName.GetCustomerName());
        Console.WriteLine("ADDRESS: ");
        Console.WriteLine(_address.GetAddress());
        Console.WriteLine("____________________________________");
        Console.WriteLine("ORDER NO: 000-000-000");
        Console.WriteLine("SHIP DATE: 03/31/32");
        Console.WriteLine("");
        Console.WriteLine("____________________________________");
        Console.WriteLine("COMMENTS: ");
    }
}