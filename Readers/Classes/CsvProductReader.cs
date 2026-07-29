using ProductApp.Models;
using ProductApp.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Readers.Classes
{
    public class CsvProductReader : IProductReader
    {
        private readonly string _filePath;

        public CsvProductReader(string filePath)
        {
            this._filePath = filePath;
        }

        public IEnumerable<Product> ReadProducts()
        {
            var products = new List<Product>();

            var lines = File.ReadAllLines(_filePath);


            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var data = line.Split(',');

                var product = new Product(data[0], data[1], double.Parse(data[2]), int.Parse(data[3]));

                products.Add(product);
            }

            return products;
        }
    }
}
