using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Bebe
    {
        public string Ad { get; set; }//Bebeğin propertyleri
        public string SoyAd { get; set; }
        public DateTime Dtarih { get; set; }

        public Bebe()//Parametre almayan Constructor 
        {
             
            Dtarih = DateTime.Now;

        }

        public Bebe(string ad, string soyad)//Parametre alan Constructor
        {
            Ad = ad;//Propertylerimizi gelecek olan  parametre  değere atıyoruz
            SoyAd = soyad;
         
            Dtarih = DateTime.Now;
            
        }

        public void BebeBilgi()
        {
            Console.WriteLine("Adı Soyadı : {0} {1} Ingaa doğum tarihi : {2} ", Ad, SoyAd, Dtarih);
        }


    }

}
