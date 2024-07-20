﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{

    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductCategory Category;


        public Product(string name, decimal price, ProductCategory category ) 
        { 
            Name = name;
            Price = price; 
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - ${Price}";
        }


    }
}
