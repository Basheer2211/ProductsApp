using ProductApp.Readers.Classes;
using ProductApp.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Factories
{
    public class ProductReaderFactory
    {
        
        public static IProductReader Create(string type, string path =null)
        {
            path = path == "" ? "products.csv" : path;
            switch (type.ToLower())
            {
                case "console": return new ConsoleProductReader();
                    

                case "csv": return new CsvProductReader(path);

                default: throw new ArgumentException("Invalid reader type");
            }
            ;

        }
    }
}
