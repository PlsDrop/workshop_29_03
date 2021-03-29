using System;
using Xunit;
using workshop;

namespace workshop.Tests
{
    public class CheckoutServiceTest
    {
        [Fact]
        public void AddProduct()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }
    }
}
