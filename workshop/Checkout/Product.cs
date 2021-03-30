using System;
using System.Collections.Generic;

namespace workshop
{
    public class Product 
    {
        internal readonly int price;
        internal readonly String name;
        internal readonly Category category;
        internal readonly TM tm;

        public Product(int price, String name, TM tm, Category category) 
        {
            this.price = price;
            this.name = name; 
            this.tm = tm;
            this.category = category;
        }

        public Product(int price, String name, TM tm) {
            this.price = price;
            this.name = name;
            this.tm = tm;
        }
    }
}
