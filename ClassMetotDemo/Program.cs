using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.FirstName = "Halil";
            product1.LastName = "Nerber";
            product1.İl = "Samsun";

            Product product2 = new Product();
            product2.Id = 2;
            product2.FirstName = "Salih";
            product2.LastName = "Mener";
            product2.İl = "Ankara";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.FirstName);
                Console.WriteLine(product.LastName);
                Console.WriteLine(product.İl);
                Console.WriteLine(product.FirstName);
            }

            Console.WriteLine("-- ekleme --");
            ProductManager manager = new ProductManager();
            manager.Ekle(product1);
            manager.Ekle(product2);

        }
    }
}
