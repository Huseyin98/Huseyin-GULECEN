using System;

namespace Aralarinda_Asallik_kontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            // kontrol edilmesi gereken sayilar 2,3,5,7,diger asal sayilar..
            int sayi,sayi2,kucuksayi;
            Console.WriteLine("birinci sayi giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci  sayi giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            //sayi2 = 12;

            
          
            int sayac = 0;
            //do
            //{
            //    sayac++;

            //    sayi = sayi / 2;

            //} while (sayi%2==0);
            if (sayi < sayi2)
            {
                kucuksayi = sayi;
            }
            else
                kucuksayi = sayi2;


            for (int i = 2; i<=kucuksayi;++i)
            {
                if (sayi%i==0 && sayi2%i==0)
                {
                    //do
                    //{

                    //} while (true);
                    //sayi = sayi / i;
                    sayac++;

                }
            }

            if(sayac==0)
            {
                Console.WriteLine("Sayi aralarinda  asaldir");

            }
            if (sayac != 0)
            {
                Console.WriteLine("Sayi aralarinda asal degildir");

            }

            Console.WriteLine(sayac);
            Console.ReadLine();



        }
    }
}
