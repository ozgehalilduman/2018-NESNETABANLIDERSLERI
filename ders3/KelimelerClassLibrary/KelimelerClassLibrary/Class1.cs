using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimelerClassLibrary
{    
    public class Kelimeler_islem
    {
        public List<string> Kelimeler=new List<string>();
        public void Listele()
        {
            #region LİSTELEME İÇİN EKSİ YÖNTEMLER
            ////yontem-1
            //for (int i = 0; i < Kelimeler.Count; i++)
            //{
            //    Console.WriteLine(Kelimeler[i]);
            //}
            ////yontem-2
            //foreach (string kelime in Kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}
            #endregion
            //yontem-3
            Kelimeler.ForEach(x=>Console.WriteLine(x));
        }
        public void Ekle(string yeniK)
        {
            Kelimeler.Add(yeniK);
        }
        public void Sil(string silinecekK)
        {
            Kelimeler.Remove(silinecekK);
        }
        public void Guncelleme(string arananK,string guncelK)
        {
            int index = Kelimeler.FindIndex(x => x == arananK);
            Kelimeler[index] = guncelK;
        }
    }
}
