public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

     public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetCost();
        }

        if (!_customer.IsFromUSA())
        {
            total += 35; 
        }
        else 
        {
            total += 5; 
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = _customer.GetCustomerInfo() + "\nProducts:\n";
        foreach (Product product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();
    }
}   
   