using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Enes", "Neval", "Serpil" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Enes", "Neval", "Serpil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Brlk");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
