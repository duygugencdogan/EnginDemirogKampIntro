using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme","Programlamaya Başlangıç","Java","Python","C#"};

            /*
            for (int i = 0; i < kurslar.Length; i+=1)
            {
                Console.WriteLine(kurslar[i]);
            }
            */

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
