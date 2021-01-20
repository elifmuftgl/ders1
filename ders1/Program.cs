using System;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMı = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun) 

            {
                Console.WriteLine("azalış butonu");

            }

            else if (dolarDun<dolarBugun)
            {

                Console.WriteLine("artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }






            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            
           
          
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            

          




            Console.WriteLine(kategoriEtiketi);
        }
    }
}
