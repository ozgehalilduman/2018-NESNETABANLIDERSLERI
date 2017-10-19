using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KelimelerClassLibrary;

namespace SOZLUKConsoleApp
{
    class Program
    {
        static Kelimeler_islem Sozluk = new Kelimeler_islem();
        static void Main(string[] args)
        {            
            #region TEST
            ////FONKSİYONLARı Görebilmek ADINA BAŞLANGIÇ DEGERLERİ OLUŞTURUYORUM..
            //Sozluk.Kelimeler=new List<string>{"Elam","Armut","Pişmaniye","Pilaki" };
            //Sozluk.Ekle("çamaşır suyu");
            //Console.WriteLine("ORJİNAL LİSTE**************");
            //Sozluk.Listele();
            //Console.ReadKey();
            //Console.WriteLine("GUNCELLENEN LİSTE**************");
            //Sozluk.Guncelleme("Elam", "elma");
            //Sozluk.Listele();
            //Console.ReadKey();
            //Console.WriteLine("Silinen Lİste**************");
            //Sozluk.Sil("Pilaki");
            //Sozluk.Listele();
            //Console.ReadKey();
            #endregion
            string secim="";
            while(secim!="0")
            {
                secim = menu();
                switch (secim)
                {
                    case "1": 
                        Ekleme_isl();
                        break;
                    case "2":
                        Silme_isl();
                        break;
                    case "3":
                        Guncelleme_isl();
                        break;
                    case "4":
                        Sozluk.Listele();
                        break;
                    case "0":
                        Console.WriteLine("ÇIKIŞ İŞLEMİ");
                        break;
                    default:
                        Console.WriteLine("HATALI İŞLEMİ");
                        Console.ReadKey();
                        break;
                }
                //Console.ReadKey();
            }
            
        }
        static string menu()
        {
            Console.Clear();
            Console.WriteLine("********* MENU ************");
            Console.WriteLine("[[ 1 ]] EKLE");
            Console.WriteLine("[[ 2 ]] SİL");
            Console.WriteLine("[[ 3 ]] GUNCELLE");
            Console.WriteLine("[[ 4 ]] LİSTELE");
            Console.WriteLine("==================");
            Console.WriteLine("[[ 0 ]] ÇIKIŞ");
            Console.Write("SECİMİNİZ : ");
            string secim = Console.ReadLine();
            return secim;
        }
        static void Ekleme_isl()
        {
            Console.WriteLine("==================");
            Console.Write("EKLENECEK YENİ DEGERİ GİRİNİZ   :   ");
            string yeni = Console.ReadLine();
            Console.WriteLine("==================");
            Sozluk.Ekle(yeni);
            Sozluk.Listele();
            Console.ReadKey();
        }
        static void Silme_isl()
        {
            Console.WriteLine("________ORJİNAL LİSTE______");
            Sozluk.Listele();
            Console.WriteLine("==================");
            Console.Write("SİLİNECEK DEGERİ GİRİNİZ   :   ");
            string silinecek = Console.ReadLine();
            Console.WriteLine("==================");
            Sozluk.Sil(silinecek);
            Sozluk.Listele();
            Console.ReadKey();
        }
        static void Guncelleme_isl()
        {
            Console.WriteLine("________ORJİNAL LİSTE______");
            Sozluk.Listele();
            Console.WriteLine("==================");
            Console.Write("GUNCELLENECEK DEGERİ GİRİNİZ   :   ");
            string aranan = Console.ReadLine();
            Console.WriteLine("==================");            
            Console.Write("YENİ DEGERİ GİRİNİZ   :   ");
            string guncelBilgi = Console.ReadLine();
            Console.WriteLine("==================");
            Sozluk.Guncelleme(aranan,guncelBilgi);
            Sozluk.Listele();
            Console.ReadKey();
        }
    }
}
