using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_simple_kolleksiyonlar
{
    class Program
    {
        //Kolleksiyonu tanımlama
        List<int> kolleksiyon_int=new List<int>();

        static void Main(string[] args)
        {
            Program ornek = new Program();
            ornek.Ekle(5);
            ornek.Ekle(20);
            ornek.Ekle(18);
            ornek.Ekle(33);
            ornek.Listele();
            ornek.Sil(2);
            ornek.Sil(ornek.Bul(20));
            Console.WriteLine("=================");
            ornek.Listele();
            Console.ReadKey();
        }
        public void Listele_eski()
        {
            for(int i=0;i<kolleksiyon_int.Count;i++)
            {
                Console.WriteLine("\t-{0}-",kolleksiyon_int[i]);                
            }
        }
        //CRUD - READ
        public void Listele()
        {
            kolleksiyon_int.ForEach(x=>Console.WriteLine("\t-{0}-",x));
        }
        //kolleksiyona yeni deger ekleme
        //CRUD - CREATE
        public void Ekle(int yeni)
        {
            //Add komutu kolleksiyona deger ekler
            kolleksiyon_int.Add(yeni);
        }
        public int Bul(int item)
        {
            int sonuc = kolleksiyon_int.FindIndex(x => x == item);
            return sonuc;
        }
        //CRUD - DELETE
        public void Sil()
        {
            kolleksiyon_int.Clear();
        }
        public void Sil(int index)
        {
            kolleksiyon_int.RemoveAt(index);
        }
        //CRUD - UPDATE
        public void Guncelle()
        {

        }

    }
}
