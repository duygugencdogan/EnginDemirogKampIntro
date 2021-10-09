using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product //Entity
    {
        //Bu tip class'larda sadece özellikler olur.
        //snippet - hazır kodlar
        public int Id { get; set; }
        public int CategoryId { get; set; } //Foreign Key - Referans Anahtarı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //Ekleme, Silme, Oluşturma, Güncelleme gibi işlemlere CRUD Operasyonları denir.
        //CRUD -> Create, Read, Update, Delete

    }
}
