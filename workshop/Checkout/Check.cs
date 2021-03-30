using System;
using System.Collections.Generic;

namespace workshop
{
    public class Check 
    {
        private List<Product> products = new List<Product>();
        private int points = 0;

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

        public int GetTotalPoints() 
        {
            return GetTotalCost() + points;
        }

        internal void AddPoints(int points) 
        {
            this.points += points;
        }

        internal int GetCostByCategory(Category category) 
        {
            int costByCategory = 0;
            foreach (Product product in products)
            {
                if (product.category == category)
                {
                    costByCategory += product.price;
                }
            }
            return costByCategory;
        }
    }
}
