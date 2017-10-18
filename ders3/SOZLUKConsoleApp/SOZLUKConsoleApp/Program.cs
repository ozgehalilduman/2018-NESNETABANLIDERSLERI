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
                        Console.WriteLine("EKLEME İŞLEMİ");
                        Eklem_isl();
                        break;
                    case "2":
                        Console.WriteLine("silme İŞLEMİ");
                        break;
                    case "3":
                        Console.WriteLine("güncelleme İŞLEMİ");
                        break;
                    case "4":
                        Console.WriteLine("listeleme İŞLEMİ");
                        break;
                    case "0":
                        Console.WriteLine("çıkış İŞLEMİ");
                        break;
                    default:
                        Console.WriteLine("HATALI İŞLEMİ");
                        break;
                }
                Console.ReadKey();
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
            Console.WriteLine("SECİMİNİZ :");
            string secim = Console.ReadLine();
            return secim;
        }
        static void Eklem_isl()
        {
            Console.WriteLine("==================");
            Console.Write("EKLENECEK YENİ DEGERİ GİRİNİZ   :   ");
            string yeni = Console.ReadLine();
            Console.WriteLine("==================");
            Sozluk.Ekle(yeni);
            Sozluk.Listele();
        }
    }
}
