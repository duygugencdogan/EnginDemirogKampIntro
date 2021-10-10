using System;
using System.Collections.Generic;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kitap kitap = new Kitap { Id = 1, TurId = 1, KitapAdi = "Kolera Günlerinde Aşk", Yazar = "Gabriel Garcia Marquez", SayfaSayisi = 300, PublishDate = "01-01-2002", Aciklama = "Güzel kitap", KayitTarihi=DateTime.Now};
            //Okur okur = new Okur { Id=1, Ad="Duygu", Soyad="Gençdoğan", Cinsiyet="Kadın", Yas=25, KayitTarihi="01-01-2000"};

            Kitap kitap = new Kitap(1, 1, "Kolera Günlerinde Aşk", "Gabriel Garcia Marquez", 300, "01-01-2000", "Güzel kitap", DateTime.Now);
            Okur okur = new Okur(1, "Duygu", "Gençdoğan", "Kadın", 25, "01-01-2000");

            KitapManager kitapManager = new KitapManager();

            kitapManager.Add(kitap);
            kitapManager.Delete(kitap);
            kitapManager.Update(kitap);
            kitapManager.Show(kitap);

            OkurManager okurManager = new OkurManager();

            okurManager.Add(okur);
            okurManager.Delete(okur);
            okurManager.Update(okur);
            okurManager.Show(okur);
        }
    }
}
