using ProductApp.Models;
using ProductApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Repositories.classes
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDataStore _dataStore;
        public ProductRepository(ProductDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public void AddProduct(Product product)
        {
            _dataStore.Add(product);
        }

        public bool Exists(string productCode)
        {
            return _dataStore.Products.Any(p => p.ProductCode == productCode);
        }

        public List<Product> GetAllProducts()
        {
            return _dataStore.Products;
        }

        public bool RemoveById(int id)
        {
            Product product = _dataStore.Products.FirstOrDefault(p => p.id == id);
            if (product != null)
            {
                _dataStore.Delete (product);
                return true;
            }
            return false;
        }
    }
}
