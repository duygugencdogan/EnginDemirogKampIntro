using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List gibi bir şeyi ben nasıl yazardım?
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            

            List<string> liste = new List<string> { };
            Console.WriteLine(liste.Count); //List içerisindeki elemanları sayar.Dizideki Length gibi.

        }
    }
}
