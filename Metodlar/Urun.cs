using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {
        //Property - Özellik - (prop)
        //Property tutan Class'lar vardır.
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
    }
    //Manager, Service, DataAccess, DAL, Control -> Ortak Operasyonlar tutan Class'lar vardır.
}
