using ProductApp.Models;
using ProductApp.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Writers.Classes
{
    public class ConsoleProductWriter : IProductWriter
    {
        public void Write(IEnumerable<Product> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Product Name : {item.ProductName}");
                Console.WriteLine($"Product Code : {item.ProductCode}");
                Console.WriteLine($"Price : {item.Price}");
                Console.WriteLine($"Quantity : {item.Quantity}");
            }
        }
    }
}
