using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        // Create addresses  
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");  
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");  

        // Create customers  
        Customer customer1 = new Customer("John Doe", address1);  
        Customer customer2 = new Customer("Jane Smith", address2);  

        // Create orders  
        Order order1 = new Order(customer1);  
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));  
        order1.AddProduct(new Product("Mouse", "P002", 25.50m, 2));  

        Order order2 = new Order(customer2);  
        order2.AddProduct(new Product("Smartphone", "P003", 599.99m, 1));  
        order2.AddProduct(new Product("Charger", "P004", 19.99m, 3));  

        // Display order details  
        Console.WriteLine(order1.GetPackingLabel());  
        Console.WriteLine(order1.GetShippingLabel());  
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");  

        Console.WriteLine(order2.GetPackingLabel());  
        Console.WriteLine(order2.GetShippingLabel());  
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}