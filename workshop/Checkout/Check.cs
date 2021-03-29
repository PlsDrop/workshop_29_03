using System;
using System.Collections.Generic;

namespace workshop.Tests
{
    public class Check
    {
        private List<Product> products = new List<Product>();

        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in this.products)
            {
                totalCost += product.price;
            }
            return totalCost; 
        }

        internal void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}