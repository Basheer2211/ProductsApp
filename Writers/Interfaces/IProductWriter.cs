using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Writers.Interfaces
{
    public interface IProductWriter
    {
        void Write(IEnumerable<Product> products);
    }
}
