using System;
using System.Collections.Generic;

namespace workshop
{
    public class CheckoutService 
    {

        private Check check;

        public void OpenCheck() 
        {
            check = new Check();
        }

        public void AddProduct(Product product) 
        {
            if (check == null) 
            {
                OpenCheck();
            }
            check.AddProduct(product);
        }

        public Check CloseCheck() 
        {
            Check closedCheck = check;
            check = null;
            return closedCheck;
        }

        public void UseOffer(Offer offer) 
        {
            offer.Apply(check);
        }
    }
}
