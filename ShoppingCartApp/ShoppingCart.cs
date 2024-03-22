using System;

namespace ShoppingCartApp
{
    public class ShoppingCartApp
    {
        private Product[] products;
        private int itemCount;

        public Product[] Products
        {
            get { return products; }
        }

        public int ItemCount
        {
            get { return itemCount; }
        }

        public ShoppingCartApp(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount++] = product;
            }
            else
            {
                Console.WriteLine("Shopping cart is full.");
            }
        }

        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i].Equals(product))
                {
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    products[itemCount - 1] = null;
                    itemCount--;
                    return;
                }
            }
            Console.WriteLine("Product not found in shopping cart.");
        }
    }
}
