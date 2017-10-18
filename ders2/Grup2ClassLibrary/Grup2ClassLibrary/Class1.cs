using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup2ClassLibrary
{
    public class Grup2Class
    {
       /// <summary>
       /// iki tam sayının bölümünden kalan sayı
       /// </summary>
       /// <param name="s1">ilk tam sayı değeri</param>
       /// <param name="s2">ikinci tam sayı değeri</param>
       /// <returns></returns>

        public int ModAl(int s1,int s2)
        {
            int sonuc;
            sonuc = s1 % s2;
            return sonuc;
        }
        public void Karekoku(int s1)
        {
            int sonuc;
            double ss = Convert.ToDouble(s1);
            sonuc = Convert.ToInt32(Math.Sqrt(s1));
        }
        public int Karesi(int s1)
        {
            int sonuc = s1 * s1;
            return sonuc;
        }
        public List<int> Kupu(List<int> Sayilar)
        {
            List<int> sonuc = new List<int>();
            for (int i = 0; i < Sayilar.Count; i++)
            {
                sonuc[i] = Sayilar[i] * Sayilar[i] * Sayilar[i];
            }
            return sonuc; 
           
             
        }
        public List<int> Karesi(List<int> Sayilar)
        {
            List<int> sonuclar = new List<int>();
            for (int i = 0; i < Sayilar.Count; i++)
            {
                sonuclar[i] = Sayilar[i] * Sayilar[i];
            }
            return sonuclar;
        }

    }
}
