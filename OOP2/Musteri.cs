using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Classların iki tipi vardır : biri içeride Özellikler tutar, biri içeride Operasyonlar tutar.
    ///Operasyon tuttuğumuz yerde Özellik tutmuyoruz.
    ///Özellik tuttuğumuz yerde Operasyon tutmuyoruz.
    //Bir veri üzerinde matematik işlemleri yapmıyorsan string olarak kullanırsın.
    //Eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa o nesneye ait gibi durmuyorsa orada soyutlama hatası yapıyorsundur.
    //Bugfree kod olmaz.

    //Ebeveyn - Patern - Base Class
    class Musteri
    {   //Ortak Özellikler burada yazılır.
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
