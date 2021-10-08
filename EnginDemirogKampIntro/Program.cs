using System;

namespace EnginDemirogKampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int OgrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmismi = false;

            if (SistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu...");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu...");
            }

        }
    }
}
