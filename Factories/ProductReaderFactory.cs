using ProductApp.Readers.Classes;
using ProductApp.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Factories
{
    public class ProductReaderFactory
    {
        public static IProductReader Create(string type)
        {
            switch (type.ToLower())
            {
                case "console": return new ConsoleProductReader();

                case "csv": return new CsvProductReader("products.csv");

                default: throw new ArgumentException("Invalid reader type");
            }
            ;

        }
    }
}
