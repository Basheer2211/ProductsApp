using ProductApp.Readers.Classes;
using ProductApp.Readers.Interfaces;
using ProductApp.Writers.Classes;
using ProductApp.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Factories
{
    public class ProductWriterFactory
    {
        public static IProductWriter Create(string type)
        {
              switch(type.ToLower())
            {
                case "console": return new ConsoleProductWriter();

                case "json": return new JsonProductWriter("products.json");

                default: throw new ArgumentException("Invalid writer type");
            };

        }
    }
}
