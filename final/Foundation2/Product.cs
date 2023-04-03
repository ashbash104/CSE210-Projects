using System;

class Product
{

    public string _name;
    public int _id;
    public double _price;
    public int _priceInt;
    public int _quantity;
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