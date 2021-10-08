using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {



            //OBJELERE DEGER ATAMASI
            //OBJE OLUSTURMA
            Araba araba1 = new Araba();
            araba1.Marka = "Mercedes";
            araba1.BeygirGucu = 5000;
            araba1.Yas = 5;
            araba1.Renk = "Siyah";

            Araba araba2 = new Araba();
            araba2.Marka = "Porsche";
            araba2.BeygirGucu = 4000;
            araba2.Yas = 1;
            araba2.Renk = "Kırmızı";

            Araba araba3 = new Araba();
            araba3.Marka = "BMW";
            araba3.BeygirGucu = 3000;
            araba3.Yas = 10;
            araba3.Renk = "Beyaz";

            //CLASS TIPINDE DIZI OLUŞTURMA
            Araba[] arabalar = new Araba[] { araba1, araba2, araba3 };
            
            //FOR DONGUSU
            for(int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine("---");
                Console.WriteLine("Araba Markası: " + arabalar[i].Marka);
                Console.WriteLine("Beygir Gücü: " + arabalar[i].BeygirGucu);
                Console.WriteLine("Yaş: " + arabalar[i].Yas);
                Console.WriteLine("Renk: " + arabalar[i].Renk);
            }
            
            //FOREACH DONGUSU
            //type-safe - tip güvenli
            foreach(var araba in arabalar)
            {
                Console.WriteLine("---");
                Console.WriteLine("Araba Markası: " + araba.Marka);
                Console.WriteLine("Beygir Gücü: " + araba.BeygirGucu);
                Console.WriteLine("Yaş: " + araba.Yas);
                Console.WriteLine("Renk: " + araba.Renk);
            }
        }

    }

    //CLASS OLUSTURMA
    class Araba
    {
        public string Marka { get; set; }
        public int BeygirGucu { get; set; }
        public int Yas { get; set; }
        public string Renk { get; set; }

    }
}
