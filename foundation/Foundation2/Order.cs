public class Order  
{  
    private List<Product> products;  
    private Customer customer;  
    private const decimal domesticShippingCost = 5.00m;  
    private const decimal internationalShippingCost = 35.00m;  

    public Order(Customer customer)  
    {  
        this.customer = customer;  
        products = new List<Product>();  
    }  

    public void AddProduct(Product product)  
    {  
        products.Add(product);  
    }  

    public decimal CalculateTotalCost()  
    {  
        decimal totalCost = 0;  

        foreach (var product in products)  
        {  
            totalCost += product.CalculateTotalCost();  
        }  

        // Add shipping cost based on the customer's location  
        totalCost += customer.LivesInUSA() ? domesticShippingCost : internationalShippingCost;  

        return totalCost;  
    }  

    public string GetPackingLabel()  
    {  
        string label = "Packing Label:\n";  
        foreach (var product in products)  
        {  
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";  
        }  
        return label;  
    }  

    public string GetShippingLabel()  
    {  
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";  
    }  
}