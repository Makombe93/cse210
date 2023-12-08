class Order
{
    private List<Product> Products { get; set; }
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.Price * product.Quantity;
        }

        totalCost += Customer.IsInUSA() ? 5 : 35; // Shipping cost
        return Math.Round(totalCost,2);
    }

    public string GetPackingLabel()
    {
        // Generate packing label
        return $"Packing Label:\n{Customer.GetFullAddress()}\n\nProducts:";
    }

    public string GetShippingLabel()
    {
        // Generate shipping label
        return $"Shipping Label:\n{Customer.GetFullAddress()}";
    }
}
