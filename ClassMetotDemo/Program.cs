using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Duygu";
            musteri1.Soyad = "Gençdoğan";
            musteri1.Age = 25;
            musteri1.Gender = "Kadın";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.Age = 36;
            musteri2.Gender = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);

        }
        //Kurumsal Yazılım Mimarisi
        //Design Patterns
        //Best Practices
        //Solution içerisinde birden fazla proje bulunabilir.
    }
}
