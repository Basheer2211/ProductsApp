using ProductApp.Models;
using ProductApp.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Readers.Classes
{
    public class ConsoleProductReader : IProductReader
    {
        public IEnumerable<Product> ReadProducts()
        {
            var products = new List<Product>();
            while (true)
            {
                Console.WriteLine("Add another? y/n:");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
                Console.WriteLine("ProductName : ");
                var productName = Console.ReadLine();
                Console.WriteLine("ProductCode : ");
                var productCode = Console.ReadLine();
                Console.WriteLine("Price : ");
                var price = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity : ");
                var quantity = int.Parse(Console.ReadLine());
                products.Add(new Product(productCode, productName, price, quantity));
            }
             return products;
            
        }
    }
}
