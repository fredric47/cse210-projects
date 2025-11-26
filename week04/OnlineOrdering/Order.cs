using System.ComponentModel.Design.Serialization;
using System.Dynamic;

public class Order
{
    private Customer _customer;// = new Customer();
    private List<Product> _products = new List<Product>();
    public decimal TotalSubtotal()
    {
        decimal cost = 0;
        foreach (Product product in _products)
        {
            cost += product.TotalCost();
        }
        return cost;
    }

    public string PackingLabel()  //:)
    {
        //ID, Name, each item
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()}: {product.GetProductID()}\n";
        }
        return packingLabel;

    }

    public string ShippingLabel()  //:)
    {
        //Name and Address of customer
        return $"\t{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public decimal TotalPrice()  //:)
    {
        //sum + shipping (5us 35 !us)
        return TotalSubtotal() + ShippingCalculator();
    }

    public int ShippingCalculator()
    {
        int shipping = 35;
        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }
        return shipping;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}