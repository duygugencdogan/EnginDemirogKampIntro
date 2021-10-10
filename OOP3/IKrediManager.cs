using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Interface Şablon görevi görür. Normalde hepsi için ayrı ayrı classlar'ın açılması gerekir.
    //Interface arayüz, şablon demektir.
    //Interface ler genellikle Operasyonel classlarda kullanılır.
    interface IKrediManager
    {
        //KrediManager deki Hesapla() Methodunun diğer tüm sub classlar farklı şekillerde ele alır.
        //İmzanın aynı olduğu ancak içerisinin farklı olduğu durumlarda Interface kullanılır.
        //Eğer birisi KrediManager Interface'ini kullanırsa içerisinde Hesapla() Methodunu içermek zorundadır.

        void Hesapla();
        void BiSeyYap();

        //Interface leri birbirinin alternatifi olan kod içerikleri farklı olan işlemler için kullanılır.
        //Loglama -> Projede kim ne zaman hangi operasyonu çağırdıdır.O sistemde olan hareketler dökümüdür.
        //Alternatif sistemler;
        //Logları bir dosyada tutabilirsiniz.
        //Logları veri tabanında tutabilirsiniz.
        //Logları sms olarak atabilirsiniz.
        //Logları email olarak atabilirsiniz.

    }
}
