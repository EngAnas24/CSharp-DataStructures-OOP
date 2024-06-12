using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Shoping
{

    // تعريف كائن "منتج"
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    // تعريف كائن "قائمة التسوق"
    class ShoppingList
    {
        private List<Product> products;

        public ShoppingList()
        {
            products = new List<Product>();
        }

        // إضافة منتج إلى قائمة التسوق
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // حذف منتج من قائمة التسوق
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        // الحصول على إجمالي السعر لجميع المنتجات في قائمة التسوق
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }
    }

    internal class Program
    {
        static void Main()
        {
            ShoppingList myShoppingList = new ShoppingList();

            // إنشاء منتجات وإضافتها إلى قائمة التسوق
            Product product1 = new Product { Name = "شوكولاتة", Price = 5.50m, Quantity = 2 };
            Product product2 = new Product { Name = "حليب", Price = 3.25m, Quantity = 1 };
            myShoppingList.AddProduct(product1);
            myShoppingList.AddProduct(product2);

            // احتساب إجمالي السعر لجميع المنتجات في قائمة التسوق
            decimal totalPrice = myShoppingList.GetTotalPrice();
            Console.WriteLine("Total Price: " + totalPrice.ToString("C"));
            Console.ReadLine();
        }
    }
}

