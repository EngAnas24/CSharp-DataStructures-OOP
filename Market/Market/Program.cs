using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int Quentity { get; set; }
        public double Price { get; set; }

    }
    class Saling
    {
        private List<Product> product;
        public Saling()
        {
            product = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.product.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            this.product.Remove(product);
        }
      
        public void TotalPrice()
        {
            double Cost=0;
            foreach (Product product in product)
            {
                 Cost = product.Price*product.Quentity;
                Console.WriteLine("Total Price: " + Cost);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { id = 1, name = "Milk", Quentity = 20, Price = 50 };
            Product p2 = new Product { id = 2, name = "Egges", Quentity = 30, Price = 100 };

            Saling s = new Saling();
            s.AddProduct(p1);
            s.AddProduct(p2);

            s.TotalPrice();
            Console.ReadLine();
        }
    }
}
