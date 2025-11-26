using System.Runtime.CompilerServices;

public class Product
{
    private string _productName;
    private int _productID;
    private decimal _price;
    private int _quantity;

    public decimal TotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public decimal GetProductPrice()
    {
        return _price;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }

    public void SetProductNameIDPriceQuantity(string name, int ID, decimal price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    // public void SetID(int ID)
    // {
    //     _prductID = ID;
    // }

    // public void SetPrice(float price)
    // {
    //     _price = price;
    // }

    // public void SetQuantity(int quantity)
    // {
    //     _quantity = quantity;
    // }
}