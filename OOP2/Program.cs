using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.MusteriNo = "1";
            musteri1.TcNo = "11111111111";

            //Tuzel Musteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2";
            musteri2.SirketAdi = "Dimes İçecek A.Ş.";
            musteri2.VergiNo = "1";

            //Tuzel Musteri - Gerçek Musteri
            //SOLID
            //Musteri nesnesi içinde vergi no olmaz, Tuzel musteride TC olmaz.

            //Musteri Class'ı hem GercekMusteri referansını tutabiliyor,
            //hem de TuzelMusteri referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //Base class onu inherite eden alt sınıfların referans numarasını tutabilir.
            //Oluşan bu objelerde argüman olarak Base class parametresine gönderilebilir.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            

        }
    }
}
