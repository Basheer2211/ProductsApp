using ProductApp.Models;
using ProductApp.Readers.Interfaces;
using ProductApp.Repositories.Interfaces;
using ProductApp.Services.Interfaces;
using ProductApp.Validation.Interfaces;
using ProductApp.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Services.Classes
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductValidator _productValidator;
        public ProductService(IProductRepository productRepository, IProductValidator productValidator)
        {
            this._productRepository = productRepository;
            this._productValidator = productValidator;
        }
        public void ExportProducts(IProductWriter writer)
        {
            writer.Write(_productRepository.GetAllProducts());
        }

        public void ImportProducts(IProductReader reader)
        {
            var products = reader.ReadProducts();
            foreach (var product in products)
            {
                
                var result = _productValidator.Validate(product);
                if (result == "Valid")
                {
                    _productRepository.AddProduct(product);
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
