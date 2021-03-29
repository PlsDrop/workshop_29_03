using System;
using Xunit;
using workshop;

namespace workshop.Tests
{
    public class CheckoutServiceTest
    {
        [Fact]
        public void CloseCheck_WithOneProduct()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        public void CloseCheck_WithTwoProducts()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            checkoutService.AddProduct(new Product(3, "Bread"));
            Check check = checkoutService.CloseCheck();
            
            Assert.Equal(10, check.GetTotalCost());
        }

    }
}
