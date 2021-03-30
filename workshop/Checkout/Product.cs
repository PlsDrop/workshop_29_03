using System;
using System.Collections.Generic;

namespace workshop
{
    public class Product 
    {
        internal readonly int price;
        internal readonly String name;
        internal readonly Category category;

        public Product(int price, String name, Category category) 
        {
            this.price = price;
            this.name = name; 
            this.category = category;
        }

        public Product(int price, String name) {
            this.price = price;
            this.name = name;
        }
    }
}
