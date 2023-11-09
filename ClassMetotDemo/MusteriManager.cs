using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri eklendi : " + musteri.Adi);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri listelendi : " + musteri.Adi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri silindi : " + musteri.Adi);
        }
    }
}
