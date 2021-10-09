using System;
using System.Collections.Generic; //Collections Library

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {   //IndexOutOfRangeException
            //string[] isimler = new string[] { "Engin", "Murat", "Kemal", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //Yeni bir adres atandı.
            //isimler[4] = "Duygu";
            //Console.WriteLine(isimler[0]);

            //Dizilerin uzunlukları sabittir.Sonradan değiştirilemez.Bu yüzden genellikle Koleksiyonlar kullanılır.
            //Biz genellikle Array kullanmayız. Koleksiyonları kullanırız.
            List<string> list = new List<string> { "Engin", "Murat", "Kemal", "Halil" };
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            list.Add("Tahir");
            Console.WriteLine(list[4]);
            Console.WriteLine(list[0]);
            //Listeler içerisinde bir çok sayıda faydalı Methodlar var.Öğren!!!

            //Eğer List diye bir kavram olmasaydı. Nasıl yazardık ?


        }
    }
}
