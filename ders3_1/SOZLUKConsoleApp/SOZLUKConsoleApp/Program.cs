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
            //Sozluk.Kelimeler = new List<Sozluk_oge>() {
            //                                            new Sozluk_oge(){ kelime = "ELMA", aciklama = "yenen bişey" },
            //                                            new Sozluk_oge(){ kelime = "ARMUT", aciklama = "AYILARA GÖre bişey" },
            //                                            new Sozluk_oge(){ kelime = "dayak", aciklama = "muzaffere GÖre bişey" }
            //                                           };
            //Sozluk_oge yeniK = new Sozluk_oge();
            //yeniK.kelime = "aTP11a";
            //yeniK.aciklama = "UYUMAYIN";
            //Sozluk.Ekle(yeniK);
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
            string secim = "";
            while (secim != "0")
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
                        Console.ReadKey();
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
            Sozluk_oge yeniK = new Sozluk_oge();

            Console.WriteLine("==================");
            Console.WriteLine("EKLENECEK YENİ DEGERİ GİRİNİZ   :   ");
            Console.Write("Kelime   :   ");
            yeniK.kelime = Console.ReadLine();
            Console.Write("Açıklama   :   ");
            yeniK.aciklama = Console.ReadLine();
            Console.WriteLine("==================");          

            Sozluk.Ekle(yeniK);
            Sozluk.Listele();
            Console.ReadKey();
        }
        static void Silme_isl()
        {
            string silinecek;
            Console.WriteLine("________ORJİNAL LİSTE______");
            Sozluk.Listele();
            Console.WriteLine("==================");
            Console.WriteLine("SİLİNECEK DEGERİ GİRİNİZ   :   ");
            Console.Write("Kelime   :   ");
            silinecek= Console.ReadLine();          
            Console.WriteLine("==================");
            Sozluk.Sil(silinecek);
            Sozluk.Listele();
            Console.ReadKey();
        }
        static void Guncelleme_isl()
        {
            Sozluk_oge guncelK = new Sozluk_oge();
            Console.WriteLine("________ORJİNAL LİSTE______");
            Sozluk.Listele();
            Console.WriteLine("==================");
            Console.Write("GUNCELLENECEK Kelimeyi GİRİNİZ   :   ");
            string aranan = Console.ReadLine();
            Console.WriteLine("==================");
            Console.WriteLine("YENİ DEGERİ GİRİNİZ   :   ");
            Console.Write("Kelime   :   ");
            guncelK.kelime = Console.ReadLine();
            Console.Write("Açıklama   :   ");
            guncelK.aciklama = Console.ReadLine();
            Console.WriteLine("==================");
            Sozluk.Guncelleme(aranan, guncelK);
            Sozluk.Listele();
            Console.ReadKey();
        }
    }
}
