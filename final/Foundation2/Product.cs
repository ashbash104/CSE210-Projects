using System;

class Product
{

    private string _name;
    private int _id;
    private double _price;
    private int _priceInt;
    private int _quantity;
    public List<string> products;

    public Product(string productName, int id, double price, int quantity)
    {
        _name = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    

    public int GetProductID()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }
    
        public int GetQuantity()
    {
        return _quantity;
    }

        public double GetPrice()
    {
        return _price;
    }

        public int GetProductPrice()
    {
        int _price = _priceInt;
        int totalProductPrice = _priceInt * _quantity;
        return totalProductPrice;

    }
}