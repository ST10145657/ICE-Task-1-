using System;
using System.Drawing;

public enum ProductCategory
{
	Electronics,
	Clothing,
	Home,
	Beauty,
	Groceries,
}
public class Product
	{
    internal int length;

    string name { get; set; }
		double price { get; set; } 
		ProductCategory category { get; set; } 
	public Product(string name, double price, ProductCategory category)
	{
		this.name = name;
		this.price = price;
		this.category = category;
	}

    public virtual void GetInfo()
    {
       Console.WriteLine($"Name : {name}, Price: {price}, Category: {category}");
    }


}

