using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "elif";
            int yas = 31;
            
            
            kurs kurs1 = new kurs();
            kurs1.kursadı = "C";
            kurs1.izlenmeOranı = 68;


            kurs kurs2 = new kurs();
            kurs2.kursadı = "java";
            kurs2.izlenmeOranı = 70;


            kurs kurs3 = new kurs();
            kurs3.kursadı = "python";
            kurs3.izlenmeOranı = 50;


            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3, };


            foreach (kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadı);
            }

           // Console.WriteLine(kurs1.kursadı + " : " + kurs1.izlenmeOranı);
        }
    }
    class kurs
    {
        public string kursadı { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }
    }



}
