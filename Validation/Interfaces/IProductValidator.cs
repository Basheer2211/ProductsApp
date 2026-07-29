using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Validation.Interfaces
{
    public interface IProductValidator
    {
        string Validate(Product product);
    }
}
