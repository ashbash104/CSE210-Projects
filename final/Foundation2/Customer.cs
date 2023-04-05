using System;

class Customer
{
    private string _customerName;

    public Customer(string name)
    {
        _customerName = name;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
}