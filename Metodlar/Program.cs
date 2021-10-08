using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not Repeat Yourself! - DRY - Clean Code(Temiz Kod) - Best Practices(Doğru Uygulama Teknikleri)
            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Elma";
            urun1.Fiyat = 10;
            urun1.Aciklama = "Amasya Elması";

            //instance - örnekleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

        }
    }
}
