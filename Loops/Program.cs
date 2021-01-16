using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Giriş Kursu";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya Giriş Kursu", "Java", "Python" };


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for loop bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
