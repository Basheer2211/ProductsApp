using ProductApp.Models;
using ProductApp.Validation.Interfaces;

public class ProductValidator : IProductValidator
{
    public string Validate(Product product)
    {

        if (string.IsNullOrWhiteSpace(product.ProductName))
        {
            return "Product name is required.";
        }

        if (product.Price <= 0)
        {
            return "Price must be positive.";
        }

        if (product.Quantity <= 0)
        {
            return "Quantity must be positive.";
        }

        return "Valid";
    }
}