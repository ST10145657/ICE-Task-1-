using System;
using System.Drawing;

namespace ShoppingCartApp
{

	public class ElectronicsProduct : Product
	{
		string Brand { get; set; }
		string Model { get; set; }
		double Price { get; set; }
		
		public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model) : base(name, price, category)
		{
			
			Brand = brand;
			Model = model;
			Price = price;
		}
        public override void GetInfo()
        {
            base.GetInfo();
			Console.WriteLine($"Brand :{Brand}, Model : {Model}, Price : {Price}" );
        }
    }
}