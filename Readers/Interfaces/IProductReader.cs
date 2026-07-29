using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Readers.Interfaces
{
    public interface IProductReader
    {
        public IEnumerable<Product> ReadProducts();
    }
}
