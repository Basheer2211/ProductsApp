using ProductApp.Models;
using ProductApp.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ProductApp.Writers.Classes
{
    public class JsonProductWriter : IProductWriter
    {
        private readonly string filePath;

        public JsonProductWriter(string filePath)
        {
            this.filePath = filePath;
        }
        public void Write(IEnumerable<Product> products)
        {
            var json = JsonSerializer.Serialize(
                products,
                new JsonSerializerOptions { WriteIndented = true }
                );
            Console.WriteLine(Path.GetFullPath(filePath));
            File.WriteAllText( filePath, json );
        }
    }
}
