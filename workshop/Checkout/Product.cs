using System;
using System.Collections.Generic;

public class Product 
{
    public readonly int price;
    public readonly String name;
    public Category category;

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
