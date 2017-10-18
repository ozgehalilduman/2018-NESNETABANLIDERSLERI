using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grup1ClassLibrary;
using Grup2ClassLibrary;

namespace Console_hesapMakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Grup1 EkranaCikti = new Grup1();
            Grup2 BasitDortislem = new Grup2();

            while (true)
            {
                //menu kısmı
                Console.Clear();
                Console.WriteLine("\t\t\t**********************");
                Console.WriteLine("\t\t\t*1*İKİ SAYIYI TOPLA***");
                Console.WriteLine("\t\t\t*2* UC SAYIYI TOPLA***");
                Console.WriteLine("\t\t\t*3*DORT SAYIYI TOPLA**");
                Console.WriteLine("\t\t\t*4*İKİ SAYIYI CARP****");
                Console.WriteLine("\t\t\t*5* UC SAYIYI CARP****");
                Console.WriteLine("\t\t\t*6*DORT SAYIYI CARP***");
                Console.WriteLine("\t\t\t*7*İKİ SAYININ FARKI**");
                Console.WriteLine("\t\t\t*8*İKİ SAYIYI BOL*****");
                Console.WriteLine("\t\t\t***GELİŞMİŞ İŞLEMLER**");
                Console.WriteLine("\t\t\t*9*İKİ SAYININ MOD AL*");
                Console.WriteLine("\t\t\t*10******KARESİ*******");
                Console.WriteLine("\t\t\t*11****KAREKOKU*******");
                Console.WriteLine("\t\t\t*12****ASAL MI?*******");
                Console.WriteLine("\t\t\t**********************");
                Console.WriteLine("\t\t\t******ÇIKIŞ [0]*******");
                Console.Write("\t\t\t***SEÇİMİNİZ********");
                string secim = Console.ReadLine();
                if (secim == "0") { break; }
                int sayi1,sayi2,sayi3,sayi4;
                int sonuc;
                switch (secim)
                {
                    case "1":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        sonuc=BasitDortislem.topla(sayi1, sayi2);
                        EkranaCikti.temizyaz(sonuc);
                        EkranaCikti.RenkliYaz(sonuc);
                        EkranaCikti.ArkaFondegistirYaz(sonuc);
                        break;

                    case "2":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-3- :");
                        sayi3 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "3":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-3- :");
                        sayi3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-4- :");
                        sayi4 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "4":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "5":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-3- :");
                        sayi3 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "6":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-3- :");
                        sayi3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-4- :");
                        sayi4 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "7":
                        Console.Write("S7ayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "8":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "9":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sayı-2- :");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "10":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());                        
                        break;
                    case "11":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "12":
                        Console.Write("Sayı-1- :");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
           
        }
    }
}
