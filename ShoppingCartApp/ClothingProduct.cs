using System;
using System.Drawing;

public class ClothingProduct : Product
{
	string Size { get; set; }
	string Color { get; set; }
	string Name { get; set; }
	string Price { get; set; }
	string Category { get; set; }


	public ClothingProduct(string name, double price, ProductCategory category, string size, string color): base(name,price,category)
	{
       this.Name = name;
		this.Price = Price;
		this.Category = Category;
		this.Size = size;
		this.Color = color;

	}

	public override void GetInfo()
	{
		base.GetInfo();
		Console.WriteLine($"Name : {Name}, Price: {Price}, Category:{Category}, Size : {Size}, Color : {Color}");
	}
}