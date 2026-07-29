using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductApp.Models
{
    public class Product  
    {
        static int idOfProduct = 1;
        public int id { get; private set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string productCode, string name, double price, int quantity)
        {
            this.id = idOfProduct++;
            this.ProductCode = productCode;
            this.ProductName = name;
            Price = price;
            this.Quantity = quantity;
        }
        public Product(string productCode, string name)
        {
            this.id = idOfProduct++;
            this.ProductCode = productCode;
            this.ProductName = name;
        }
    }
}
