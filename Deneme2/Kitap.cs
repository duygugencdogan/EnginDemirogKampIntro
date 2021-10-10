using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2
{
    class Kitap
    {
        //Constructor Method - Geri dönüş tipi olmaz. (ctor - tab - tab)
        public Kitap(int _Id, int _TurId, string _KitapAdi, string _Yazar, int _SayfaSayisi, string _BasimTarihi, string _Aciklama, DateTime _KayitTarihi)
        {
            Id = _Id;
            TurId = _TurId;
            KitapAdi = _KitapAdi;
            Yazar = _Yazar;
            SayfaSayisi = _SayfaSayisi;
            BasimTarihi = _BasimTarihi;
            Aciklama = _Aciklama;
            KayitTarihi = _KayitTarihi;
        }

        public int Id;
        public int TurId;
        public string KitapAdi;
        public string Yazar;
        public int SayfaSayisi;
        public string BasimTarihi;
        public string Aciklama;
        public DateTime KayitTarihi;


        
    }
}
