using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DortislemClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sınıfdan nesne türetme-örnekleme
            Dortislem dort_islem = new Dortislem();
            dort_islem.sayi1 = 100;
            dort_islem.sayi2 = 50;
            int sonuc=dort_islem.toplama();

            int sonuc2 = dort_islem.toplama(54,34);
            int sonuc3 = dort_islem.toplama(54,34,12);


            string msj = "ATP-11- NESNE TABANLI PROGRAMLAMA";
            Console.WriteLine(msj);
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.ReadKey();
        }
    }
}
