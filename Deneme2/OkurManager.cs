using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2
{
    class OkurManager
    {
        public void Add(Okur okur)
        {
            Console.WriteLine("Added.");
        }

        public void Update(Okur okur)
        {
            Console.WriteLine("Updated.");
        }
        public void Delete(Okur okur)
        {
            Console.WriteLine("Deleted.");
        }

        public void Show(Okur okur)
        {
            Console.WriteLine("Showed.");
        }
    }
}
