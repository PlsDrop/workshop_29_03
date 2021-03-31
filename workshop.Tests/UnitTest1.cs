using System;
using Xunit;
using workshop;

public class CheckoutServiceTest 
{

    private Product milk_7;
    private CheckoutService checkoutService;
    private Product bread_3;

    public CheckoutServiceTest() 
    {
        checkoutService = new CheckoutService();
        checkoutService.OpenCheck();

        milk_7 = new Product(7, "Milk", TM.PROSTOKWASHINO, Category.MILK);
        bread_3 = new Product(3, "Bread", TM.HLEBOBULOCHNAYA);
    }

    [Fact]
    void CloseCheck_WithOneProduct() 
    {
        checkoutService.AddProduct(milk_7);
        Check check = checkoutService.CloseCheck();

        Assert.Equal(7, check.GetTotalCost());
    }

    [Fact]
    void CloseCheck_WithTwoProducts() 
    {
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(bread_3);
        Check check = checkoutService.CloseCheck();

        Assert.Equal(10, check.GetTotalCost());
    }

    [Fact]
    void AddProduct_WhenCheckIsClosed_OpensNewCheck() 
    {
        checkoutService.AddProduct(milk_7);
        Check milkCheck = checkoutService.CloseCheck();
        Assert.Equal(7, milkCheck.GetTotalCost());

        checkoutService.AddProduct(bread_3);
        Check bredCheck = checkoutService.CloseCheck();
        Assert.Equal(3, bredCheck.GetTotalCost());
    }

    [Fact]
    void CloseCheck_CalcTotalPoints() 
    {
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(bread_3);
        Check check = checkoutService.CloseCheck();

        Assert.Equal(10, check.GetTotalPoints());
    }

    /* [Fact]
    void UseOffer_AddOfferPoints() 
    {
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(bread_3);

        checkoutService.UseOffer(new AnyGoodsOffer(6, 2));
        Check check = checkoutService.CloseCheck();

        Assert.Equal(12, check.GetTotalPoints());
    } */

    /* [Fact]
    void UseOffer_WhenCostLessThanRequired_DoNothing() 
    {
        checkoutService.AddProduct(bread_3);

        checkoutService.UseOffer(new AnyGoodsOffer(6, 2));
        Check check = checkoutService.CloseCheck();

        Assert.Equal(3, check.GetTotalPoints());
    } */

  
    [Fact]
    void UseBonusOffer()
    {
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(bread_3);

        checkoutService.UseOffer(new BonusOffer(new DateTime(2023,01,02), new ByCategory(Category.BREAD), new FlatReward(40)));
        Check check = checkoutService.CloseCheck();

        Assert.Equal(57, check.GetTotalPoints());
    }
        
    [Fact]
    void UseDiscountOffer()
    {
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(bread_3);

        checkoutService.UseOffer(new DiscountOffer(new DateTime(2023,01,02), new ByTradeMark(TM.PROSTOKWASHINO), new PercentDiscount(50)));
        Check check = checkoutService.CloseCheck();

        Assert.Equal(11, check.GetTotalPoints());
    }

    [Fact]
    void UseExpiredOffer() 
    {
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(milk_7);
        checkoutService.AddProduct(bread_3);

        checkoutService.UseOffer(new BonusOffer(new DateTime(2020,01,02), new ByCategory(Category.BREAD), new FlatReward(40)));
        Check check = checkoutService.CloseCheck();

        Assert.Equal(17, check.GetTotalPoints());
    }



    // void UseCompositeCondition()
    // {
    //     checkoutService.AddProduct(milk_7);
    //     checkoutService.AddProduct(milk_7);
    //     checkoutService.AddProduct(bread_3);

    //     checkoutService.UseOffer(new BonusOffer(DateTime(2023.01.02), Composite.all(new ByCategory(Category.BREAD), new NyTrademard('HlibTaKava')), new FlatReward(40)));
    //     Check check = checkoutService.CloseCheck();

    //     Assert.Equal(97, check.GetTotalPoints());
    // }
}
