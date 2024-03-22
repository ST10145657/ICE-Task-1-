using System;

namespace ShoppingCartApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ElectronicsProduct electronicsProduct = new ElectronicsProduct("electronicName", 0, ProductCategory.Electronics, "electronicbrand", "electroicmodel");
            ClothingProduct clothingProduct = new ClothingProduct("ClothingName", 0, ProductCategory.Clothing, "Clothingsize","CothingColor");

            ShoppingCartApp shoppingCart = new ShoppingCartApp(10);
            shoppingCart.AddProduct(electronicsProduct);
            shoppingCart.RemoveProduct(clothingProduct);

            Console.WriteLine("Please enter clothing name:");
            string clothingName = Console.ReadLine();
            Console.WriteLine("Please enter clothing price:");
            double clothingPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter clothing size:");
            string clothingSize = Console.ReadLine();
            Console.WriteLine("Please enter clothing colour:");
            string clothingColor = Console.ReadLine();

            Console.WriteLine("Please enter electronic name:");
            string electronicName = Console.ReadLine();
            Console.WriteLine("Please enter electronics brand:");
            string electronicBrand = Console.ReadLine();
            Console.WriteLine("Please enter model:");
            string electronicModel = Console.ReadLine();
            Console.WriteLine("Please enter Electronics price:");
            double electronicPrice = Convert.ToDouble(Console.ReadLine());

            ClothingProduct userClothing = new ClothingProduct(clothingName, clothingPrice, ProductCategory.Clothing, clothingSize, clothingColor);
            shoppingCart.AddProduct(userClothing);

            ElectronicsProduct userElectronics = new ElectronicsProduct(electronicName, electronicPrice, ProductCategory.Electronics, electronicBrand, electronicModel);
            shoppingCart.AddProduct(userElectronics);

            Console.WriteLine("Items in the shopping cart:");
            foreach (var product in shoppingCart.Products)
            {
                if (product != null)
                {
                    product.GetInfo();
                }
            }
        }
    }
}
