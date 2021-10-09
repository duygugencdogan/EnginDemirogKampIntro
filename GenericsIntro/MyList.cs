using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //Generics - Generic Tipler - Generic Tiplerin Mantığı
    //Generic Class - Tip bağımlı olarak çalışıyor vereceğin tipe göre oluşturulacak.
    class MyList<T>
    {
        //Class içerisinde tanımlanmış bir dizi.Class içerisinde her yerden erişilebilir.
        T[] items;

        //Constructor - Yapıcı Method - Class dan obje oluşturulduğunda ilk olarak Constructorlar çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
