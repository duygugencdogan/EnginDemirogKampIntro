using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //sepete ürün ekleme işlemi
        //syntax
        //signature
        //encapsulation - kapsülleme
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! " + urun.UrunAdi + " sepete eklendi");
        }
        
    }
}
