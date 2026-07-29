using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Repositories.Interfaces
{
    public interface IProductRepository 
    {
        public List<Product> GetAllProducts();
        public void AddProduct(Product product);
        public bool RemoveById(int id);
        bool Exists(string productCode);
    }
}
