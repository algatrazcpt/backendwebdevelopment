using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Pratik2.Models;
namespace Pratik2.Controllers
{
    public class CustomerOrdersController:Controller
    {
        public static List<Customer> customersList=new List<Customer>           {
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" },
                new Customer { CustomerId = 3, FirstName = "Emily", LastName = "Jones", Email = "emily.jones@example.com" },
                new Customer { CustomerId = 4, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com" },
                new Customer { CustomerId = 5, FirstName = "Sarah", LastName = "Davis", Email = "sarah.davis@example.com" },
                new Customer { CustomerId = 6, FirstName = "Chris", LastName = "Wilson", Email = "chris.wilson@example.com" },
                new Customer { CustomerId = 7, FirstName = "Anna", LastName = "Moore", Email = "anna.moore@example.com" },
                new Customer { CustomerId = 8, FirstName = "David", LastName = "Taylor", Email = "david.taylor@example.com" },
                new Customer { CustomerId = 9, FirstName = "Sophia", LastName = "White", Email = "sophia.white@example.com" },
                new Customer { CustomerId = 10, FirstName = "James", LastName = "Harris", Email = "james.harris@example.com" }
            };
        public static List<Order> ordersList= new List<Order>
            {
                new Order { OrderId = 1, ProductName = "Laptop", Price = 1200.99m, Quantity = 1 },
                new Order { OrderId = 2, ProductName = "Smartphone", Price = 799.49m, Quantity = 2 },
                new Order { OrderId = 3, ProductName = "Headphones", Price = 199.99m, Quantity = 3 },
                new Order { OrderId = 4, ProductName = "Monitor", Price = 299.99m, Quantity = 1 },
                new Order { OrderId = 5, ProductName = "Keyboard", Price = 49.99m, Quantity = 5 },
                new Order { OrderId = 6, ProductName = "Mouse", Price = 25.49m, Quantity = 10 },
                new Order { OrderId = 7, ProductName = "Printer", Price = 129.99m, Quantity = 1 },
                new Order { OrderId = 8, ProductName = "Tablet", Price = 349.99m, Quantity = 2 },
                new Order { OrderId = 9, ProductName = "Router", Price = 89.99m, Quantity = 1 },
                new Order { OrderId = 10, ProductName = "Webcam", Price = 59.99m, Quantity = 4 }
            };
        public IActionResult Index()
        {
            ViewData["Customer"] = customersList;
            ViewData["Order"] = ordersList;
            return View();
        }
        
    }
}
