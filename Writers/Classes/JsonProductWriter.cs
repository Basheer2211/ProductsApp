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
        private readonly string _filePath;

        public JsonProductWriter(string filePath)
        {
            this._filePath = filePath;
        }
        public void Write(IEnumerable<Product> products)
        {
            var json = JsonSerializer.Serialize(
                products,
                new JsonSerializerOptions { WriteIndented = true }
                );
            Console.WriteLine(Path.GetFullPath(_filePath));
            File.WriteAllText( _filePath, json );
        }
    }
}
