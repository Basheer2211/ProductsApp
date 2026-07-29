using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Repositories.classes
{
    public class ProductDataStore
    {
        public List<Product> Products { get;  }
        private int _nextId = 1;
        public ProductDataStore()
        {
            Products = new List<Product>();
        }
        public void Add(Product product)
        {
            product.Id = _nextId++;
            Products.Add(product);
        }


        public void Delete(Product product)
        {
            Products.Remove(product);
        }


        public void Update(Product product)
        {
            var existingProduct = Products.FirstOrDefault(p => p.id == product.id);
            if (existingProduct != null)
            {
                Products.Remove(existingProduct);
                Products.Add(product);
            }
            else
            {
                throw new Exception("Product not found");
            }
        }


    }
}
