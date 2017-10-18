using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRUP1ClassLibrary;
using Grup2ClassLibrary;
using Grup3;

namespace Hesapmakinasi_v_2_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Grub1class dortislem = new Grub1class();
            Grup2Class gelismisislemler = new Grup2Class();
            Grup3Class inputoutput = new Grup3Class();
            while (true)
            {
                //menu kısmı
                Console.Clear();
                Console.WriteLine("\t\t\t**********************");
                Console.WriteLine("\t\t\t*1*İKİ SAYIYI TOPLA***");
                Console.WriteLine("\t\t\t*2*SAYILARI TOPLA  ***");
                Console.WriteLine("\t\t\t*3*İKİ SAYIYI CARP****");
                Console.WriteLine("\t\t\t*4*SAYILARI CARP  ****");
                Console.WriteLine("\t\t\t*5*İKİ SAYININ FARKI**");
                Console.WriteLine("\t\t\t*6*İKİ SAYIYI BOL*****");
                Console.WriteLine("\t\t\t***GELİŞMİŞ İŞLEMLER**");
                Console.WriteLine("\t\t\t*7*İKİ SAYININ MOD AL*");
                Console.WriteLine("\t\t\t*8******KARESİ *******");
                Console.WriteLine("\t\t\t*9******KARELERİSİ ***");
                Console.WriteLine("\t\t\t*10****KAREKOKU*******");
                Console.WriteLine("\t\t\t*11****KAREKOKLERİ****");
                Console.WriteLine("\t\t\t**********************");
                Console.WriteLine("\t\t\t******ÇIKIŞ [0]*******");
                Console.Write("\t\t\t***SEÇİMİNİZ********/t");
                string secim = Console.ReadLine();
                if (secim == "0") { break; }
                int sayi1, sayi2, sayi3, sayi4;
                int sonuc;
                switch (secim)
                {
                    case "4":
                        for(int i=0;i<5;i++)
                        {
                            inputoutput.DegerGir();
                        }
                        sonuc = dortislem.carp(inputoutput.DegerleriAl());
                        inputoutput.Ekranyaz(sonuc);
                        inputoutput.Renkliyaz(sonuc, ConsoleColor.Yellow);
                        inputoutput.Arkasirenkliyaz(sonuc, ConsoleColor.DarkMagenta);
                        break;

                    
                    case "1":
                        
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
