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
        private int quantity = 0;
        private string imagePath = string.Empty; // added imagePath field
        private string size = string.Empty;
        private DateTime date = DateTime.Now;

        // Updated constructor
        // The constructor initializes a new Product with the given values.
        public Product(string name, string category, string imagePath)
        {
            Name = name;
            Category = category;
            ImagePath = imagePath;
            Size = string.Empty;
            Quantity = 0;
            Date = DateTime.Now;
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

        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = string.IsNullOrEmpty(value) ? "default.png" : value;
            }
        }

        public string Size { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Category}) - {Size}, Qty: {Quantity}, Date: {Date.ToShortDateString()}";
        }

    }
}
