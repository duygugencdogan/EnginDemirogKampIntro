using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //Interfaces
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ////Interface lerde o interface i implemente eden class ların referans numarasını tutabilir.
            //IKrediManager krediManager1 = new IhtiyacKrediManager();
            //krediManager1.Hesapla();
            //IKrediManager krediManager2 = new TasitKrediManager();
            //krediManager2.Hesapla();
            //IKrediManager krediManager3 = new KonutKrediManager();
            //krediManager3.Hesapla();

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();


            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);
            BasvuruManager basvuruManager = new BasvuruManager();

            //List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager  };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {databaseLoggerService, new SmsLoggerService() });

            //Yazılımda sürüdürülebilirlik sağlanır. Yeni isteklere hazır olmak lazım.
            //Reverse Engineering
            //Abstract Classes
        }
    }
}
