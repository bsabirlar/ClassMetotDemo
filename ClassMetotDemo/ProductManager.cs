using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ProductManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Yeni Müşteri Eklendi. : " + product.FirstName);
        }

        public void List(Product product)
        {
            Console.WriteLine("Müşteriler Listesi : " + product.Id + " " + product.FirstName);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("delete : " + product.İl );
        }
    }
}
