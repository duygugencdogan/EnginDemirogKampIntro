using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Interface'i implemente eden Class'lar Metodun içini kendine göre doldurmalı.
    //Interface ler genellikle Operasyonel classlarda kullanılır.
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //
            //
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");
        }
    }
}
