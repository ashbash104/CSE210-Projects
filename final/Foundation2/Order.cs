using System;

class Order 
{
    Address _address;
    Customer _customer;
    List<Product> products;
    public int _shippingCost;
    List<string> _listOrder = new List<string> 
    {
        " ", " "
    };
    public Order(string name, string streetAddress, string city, string state, int zip, bool usa) 
    {
        _address = new Address(streetAddress, city, state, zip, usa);
        _customer = new Customer(name);
    }
    public void AddProduct(string productName, int id, float price, int quantity)
    {
        Product newProduct = new Product(productName, id, price, quantity);
        products.Add(newProduct);
    }

    public int TotalCost()
    {

    }
    public int ShippingCost()
    {

    }
    public void PackingLabel()
    {

    }
    public void ShippingLabel()
    {
        
    }
}