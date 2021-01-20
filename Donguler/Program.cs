using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme";
            string kurs2 = "programlama";
            string kurs3 = "java";
            string kurs4 = "python";

            string[] kurslar = new String[] { "yazılım geliştirme", "programlama", "java", "python","C" };


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }


    }
}
