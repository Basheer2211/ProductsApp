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
        private readonly IProductRepository productRepository;
        private readonly IProductValidator productValidator;
        public ProductService(IProductRepository productRepository, IProductValidator productValidator)
        {
            this.productRepository = productRepository;
            this.productValidator = productValidator;
        }
        public void ExportProducts(IProductWriter writer)
        {
            writer.Write(productRepository.GetAllProducts());
        }

        public void ImportProducts(IProductReader reader)
        {
            var products = reader.ReadProducts();
            foreach (var product in products)
            {
                if (IsValidProductCode(product.ProductCode))
                {
                    Console.WriteLine($"Product with code {product.ProductCode} already exists. Skipping import.");
                    continue;
                }
                var result = productValidator.Validate(product);
                if (result == "Valid")
                {
                    productRepository.AddProduct(product);
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    
    public bool IsValidProductCode(string productCode)
        {
            return productRepository.Exists(productCode);
        } 
    }
}
