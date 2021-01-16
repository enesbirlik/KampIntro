using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güveliği
            // DON'T REPEAT YOURSELF

            string kategoreiEtiketi = "Kategori";
            int ogreanciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.5;

            if (dolarDun>dolarBugun)
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


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoreiEtiketi);
        }
    }
}
