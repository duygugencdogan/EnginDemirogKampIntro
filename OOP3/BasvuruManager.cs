using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Kredi Başvuru işlemleri
    class BasvuruManager
    {
        //Burada Method Injection Yapıyoruz.
        //Constructor Injection türüde vardır.Araştır.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgileri değerlendirme
            //

            //Bağımlılıktan kurtulduk. Buraya eger tasıt gönderirse tasıt kredisi işlemleri çalışır.
            //Konut gönderilirse konut çalışır.Program.cs'den gönderilecek komuta bağlıdır.
            krediManager.Hesapla();
            foreach(var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //Aynı veri türünde veri sayısının belirsiz olduğu durumlarda Listler kullanılır.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
