using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2
{
    class KitapManager
    {
        public void Add(Kitap kitap)
        {
            Console.WriteLine("Added.");
        }

        public void Update(Kitap kitap)
        {
            Console.WriteLine("Updated.");
        }
        public void Delete(Kitap kitap)
        {
            Console.WriteLine("Deleted.");
        }

        public void Show(Kitap kitap)
        {
            Console.WriteLine("Showed.");
        }
    }
}
