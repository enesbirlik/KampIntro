using System;

namespace e_tic
{
    class Program
    {
        static void Main(string[] args)
        {

            Products urun1 =new Products();
            urun1.UrunAdi = "Ekmek";
            urun1.Fiyat = 1.50;


            Products urun2 =new Products();
            urun2.UrunAdi = "Makarna";
            urun2.Fiyat = 3.0;

            Products urun3 =new Products();
            urun3.UrunAdi = "Çikolata";
            urun3.Fiyat = 5.95;

            Products urun4 =new Products();
            urun4.UrunAdi = "Su";
            urun4.Fiyat = 1.0;

            Products[] urunler = new Products[] { urun1, urun2, urun3, urun4 };
            foreach (var item in urunler)
            {
                Console.WriteLine(item.UrunAdi +" : "+ item.Fiyat);
            }

            //int i = 0;
            //while (i < 3)//buradaki ürün sayısını nasıl yazabilirim listeden sayım nasıl yapılıyor?

            //Console.WriteLine(urunler);
            //i++; WHİLE KISMINI YAPAMADIM :(
        }

    }
    class Products
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
    }
}
