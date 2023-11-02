namespace Classİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string adi = "engin";
            int yas = 37;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "bilgin parlak";
            kurs2.IzlenmeOrani = 60;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "ahmet kara";
            kurs3.IzlenmeOrani = 80;



            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }





            //Console.WriteLine("Hello, World!");
        }
    }

    //class:sanki sen kendi veri tipini yazıyormuşsun gibi
    class Kurs
    {
        //prop yaz tab+tab yap
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }



    }




}