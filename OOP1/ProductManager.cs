using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //Ürün ile ilgili Operasyonları bulunduran Class'tır.
        //Encapsulation. Ürün ü bütün olarak yollamak.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi.");
        }
        //array, interface, class, abstract class -> referans tipi
        //ref out keywords
        //public int Topla(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    return toplam;

        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
