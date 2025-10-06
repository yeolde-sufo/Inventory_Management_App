using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagementApp
{
    public class Product
    {
        // Fields – private variables to store product info
        //Using private fields ensures encapsulation (control over access).
        private string name = string.Empty;
        private string category = string.Empty;
        private string description = string.Empty; // added description field
        private int productId = 0; // added productId field
        private int quantity = 0;
        private decimal price = 0;
        private string imagePath = string.Empty; // added imagePath field

        // Constructor
        // The constructor initializes a new Product with the given values.
        public Product(string name, string category, string description, int productId, int quantity, decimal price, string imagePath)
        {
            Name = name;
            Category = category;
            Description = description;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            ImagePath = imagePath;
        }
        // Properties with encapsulation
        // Properties act as controlled gateways to the fields.
        // The set block ensures invalid data (like empty name) cannot be assigned.
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) 
                    name = value;
                else
                    throw new ArgumentException("Name cannot be empty");
            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    category = value;
                else
                    throw new ArgumentException("Category cannot be empty");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
                else
                    throw new ArgumentException("Description cannot be empty");
            }
        }

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value >= 0)
                    productId = value;
                else
                    throw new ArgumentException("Product must have an Id number");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
                else
                    throw new ArgumentException("Quantity cannot be negative");
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentException("Price cannot be negative");
            }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = string.IsNullOrEmpty(value) ? "default.png" : value;
            }
        }

        public override string ToString()
        {
            return $"{Name} | {Category} | {Description} | Id: {ProductId} | Qty: {Quantity} | Price: ${Price}";
        }

    }
}
