using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer customer1 = new Customer();
        customer1.SetCustomer("John Doe", "29153 FortTown NM. USA 28309");
        Customer customer2 = new Customer();
        customer2.SetCustomer("Jane Doe", "80971 Rocksville Alberta CA 69241 ");

        Product product1 = new Product();
        product1.SetProductNameIDPriceQuantity("Swiss Cheese", 47, 6.10m, 3);

        Product product2 = new Product();
        product2.SetProductNameIDPriceQuantity("Blue Cheese", 48, 5.27m, 1);

        Product product3 = new Product();
        product3.SetProductNameIDPriceQuantity("String Cheese", 49, 4.75m, 2);

        Product product4 = new Product();
        product4.SetProductNameIDPriceQuantity("Expensive Cheese", 50, 45.51m, 1);

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product1);


        //-Display by methods-
        //Packing lable
        //Shipping label
        //Total Price
        Console.WriteLine($"\n\tPacking Label: \n{order1.PackingLabel()}");
        Console.WriteLine($"\tShipping Label: \n{order1.ShippingLabel()} \t//In USA: ({customer1.LivesInUSA()})\n");
        Console.WriteLine($"\tTotal Price(After Shipping): \n${order1.TotalPrice()}\n");

        Console.WriteLine($"\n\tPacking Label: \n{order2.PackingLabel()}");
        Console.WriteLine($"\tShipping Label: \n{order2.ShippingLabel()} \t//In USA: ({customer2.LivesInUSA()})\n");
        Console.WriteLine($"\tTotal Price(After Shipping): \n${order2.TotalPrice()}\n");

    }
}