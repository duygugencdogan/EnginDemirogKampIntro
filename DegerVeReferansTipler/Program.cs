using System;
using System.Linq;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Add(int sayi1 = 10, int sayi2 = 20)
            {
                var result = sayi1 + sayi2 + x;
                return result;
            }

            Console.WriteLine(Add(20));
            //SOLID Yazılım Geliştirme Prensipleri 
            //Design Pattern
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            //int number = 10;
            //Console.WriteLine("Number is {0}", number);
            //Console.ReadLine();
            //Sayısal Veri Tipleri - Değer Tipleri : int, float, double, decimal, bool 
            //Referans Tipleri : Array, Class, Interface
            //Referans Ataması - Adres Ataması
            //Bellek ikiye ayrılır -> Stack ve Heap
            //Garbage Collector - Adresi hiçbir obje tarafından tutulmayan değerleri yok eder.
            //Yazılımda Sürdürülebilirlik önemlidir.

            //Value Type - Değer Tipleri
            //int number1 = 2147483647; //int 32 bits, long 64 bits integer
            //long number2 = 2147483648; //int i tutabilir ama bellekte fazla static yer kaplar.
            //short number3 = 32767;
            //byte number4 = 255;//8 bits = 1 byte yer tutar. (0 - 255)
            //bool condition = false; // true/false
            //char character = 'A';
            //string city = "Ankara";
            //double number5 = 10.4; //64 bits ondalıklı sayı tutar.
            //                       //decimal
            //                       //magic strings


            //Console.WriteLine("Number1 is {0}, Number2 is {1}", number1, number2);
            //Console.WriteLine("ASCII code of A: {0}", (int)character);
            //Console.WriteLine(Days.Friday);
            //Console.WriteLine((int)Days.Friday);

            ////var veri tipi
            //var number7 = 10;
            //Console.WriteLine(number7);
            ////char
            //number7 = 'A';
            //Console.WriteLine(number7);
            ////string   number7 = "Ankara";


            //switch case
            //Ctrl + K -> Ctrl + D (Okunur hale getirme)
            // Ctrl + K -> Ctrl + C (Comments)
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            //var number8 = 200;

            //if (number8 >= 0 && number8 <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number8 > 100 && number8 <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if(number8 > 200 || number8 <0)
            //{
            //    Console.WriteLine("Number is greater than 200 or less than 0");
            //}
            //Console.ReadLine();

            static void Topla(params int[] numbers)
            {
                return numbers.Sum();
            }

        }

        //enum Days
        //{
        //    Monday = 10, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday
        //}
    }
}
