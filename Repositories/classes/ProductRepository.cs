using ProductApp.Models;
using ProductApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Repositories.classes
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool Exists(string productCode)
        {
            return products.Any(p => p.ProductCode == productCode);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public bool RemoveById(int id)
        {
            Product product = products.FirstOrDefault(p => p.id == id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
