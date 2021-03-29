using System;
using System.Collections.Generic;

namespace workshop.Tests
{
    public class CheckoutService
    {
        public Check check;
        public void OpenCheck()
        {
            this.check = new Check();
        }

        public void AddProduct(Product product)
        {
            check.AddProduct(product);
        }

        public Check CloseCheck()
        {
            Check closedCheck = check;
            check = null;
            return closedCheck;
        }
    }
}