using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebe bebek = new Bebe("Ahmet","Karaboğa");//Değer alan Constructorın içine new ile ad,soyad bilgisini gonderiyoruz
            bebek.BebeBilgi();

            Bebe Bebek2 = new Bebe();//Değer almayan Constructorı Bebek2 nesnesine atayarak propertylerine tek tek veri gonderiyoruz.
            Bebek2.Ad = "Ayşe";
            Bebek2.SoyAd = "Kara";
            Bebek2.BebeBilgi();

            Console.ReadLine(); 
        }
    }
}
