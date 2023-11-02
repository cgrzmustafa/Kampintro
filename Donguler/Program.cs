using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım";
            string kurs2 = "programlama";
            string kurs3 = "python";
            string kurs4 = "java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            //array - dizi

            string[] kurslar = new string[] { "yazılım", "programlama", "python" };


            //kurslar.Lenght demek ne kadar kurs varsa onu getir demek.

            for (int i = 0; i < kurslar.Length; i++) //veya i=i+1 veya i+=1
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            //foreach dizileri tek tek dolanmaya yarıyor.


















        }
    }
}