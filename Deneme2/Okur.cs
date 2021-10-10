using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2
{
    class Okur
    {
        //Constructor Method - Geri dönüş tipi olmaz. (ctor - tab - tab)
        public Okur(int _Id, string _Ad, string _Soyad, string _Cinsiyet, int _Yas, string _KayitTarihi)
        {
            Id = _Id;
            Ad = _Ad;
            Soyad = _Soyad;
            Cinsiyet = _Cinsiyet;
            Yas = _Yas;
            KayitTarihi = _KayitTarihi;
        }

        public int Id;
        public string Ad;
        public string Soyad;
        public string Cinsiyet;
        public int Yas;
        public string KayitTarihi;
    }
}
