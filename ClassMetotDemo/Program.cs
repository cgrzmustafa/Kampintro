using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Ciğersiz";
            musteri1.Tc = "12345678910";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Hakan";
            musteri2.Soyadi = "Doğan";
            musteri2.Tc = "12345678911";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Can";
            musteri3.Soyadi = "Yılmaz";
            musteri3.Tc = "12345678912";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID: " + musteri.Id);
                Console.WriteLine("Adı: " + musteri.Adi);
                Console.WriteLine("Soyadı: " + musteri.Soyadi);
                Console.WriteLine("TC: " + musteri1.Tc);
                Console.WriteLine("-------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
        }
    }
}
