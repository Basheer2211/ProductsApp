using ProductApp.Models;
using ProductApp.Repositories.classes;
using ProductApp.Repositories.Interfaces;
using ProductApp.Validation.Interfaces;

public class ProductValidator : IProductValidator
{
    private readonly IProductRepository _repository;
    public ProductValidator(IProductRepository repository)
    {
        _repository = repository;
    }
    public string Validate(Product product)
    {
       

        if (string.IsNullOrWhiteSpace(product.ProductName))
        {
            return "Product name is required.";
        }
        if(_repository.Exists(product.ProductCode))
        {
            return "Product with this code already exists.";
        }     

        if (product.Price <= 0)
        {
            return "Price must be positive.";
        }

        if (product.Quantity <= 2)
        {
            return "Quantity must be greater than 2.";
        }

        return "Valid";
    }
}