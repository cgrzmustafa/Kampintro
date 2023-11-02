namespace ClassOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Akıllı Telefon";
            urun1.UrunFiyati = 10000;
            urun1.UrunKalan = 100;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Dizüstü Bilgisayar";
            urun2.UrunFiyati = 15000;
            urun2.UrunKalan = 122;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Akıllı Saat";
            urun3.UrunFiyati = 2000;
            urun3.UrunKalan = 453;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + ":" + urun.UrunFiyati);
            }

            
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public int UrunKalan { get; set; }
    }
}