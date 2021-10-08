using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad +"kişisi eklendi");

        }

        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listelendi");
            for(int i=0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Id:" + musteriler[i].Id + " Ad Soyad:" + musteriler[i].Ad + " " + musteriler[i].Soyad + " Age:" + musteriler[i].Age + " Gender:" + musteriler[i].Gender);
            }
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + "kişisi silindi");
        }
    }
}
