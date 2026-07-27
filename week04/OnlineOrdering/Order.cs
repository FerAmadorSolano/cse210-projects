using System;
using System.Diagnostics.Contracts;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer custom)
    {
        _customer = custom;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LiveInUsa() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        Console.WriteLine("Packing Label");
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        Console.WriteLine("Shipping Label");

        return $"{_customer.GetName()}\n{_customer.GetAddress().GetDisplayAddress()}";
    }
}