using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup2ClassLibrary
{
    /// <summary>
    /// Grup1 Elemanları:...............
    /// </summary>
    public class Grup2
    {
        /// <summary>
        /// Toplama fonksiyonu
        /// </summary>
        /// <param name="s1">toplama yapılacak sayi1</param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public int topla(int s1,int s2)
        {
            int sonuc = 0;
            sonuc = s1 + s2;
            return sonuc;
        }
        public int topla(int s1, int s2,int s3)
        {
            int sonuc = 0;
            sonuc = s1 + s2+s3;
            return sonuc;
        }
        public int topla(int s1, int s2, int s3,int s4)
        {
            int sonuc = 0;
            sonuc = s1 + s2 + s3 + s4;
            return sonuc; 
           
        }
        public int cikarma(int s1,int s2)
        {
            int sonuc = 0;            
            if(s1 > s2)
            {
                sonuc = s1 - s2;
            }
            else
            {
                sonuc = s2 - s1;
            }
            return sonuc;
        }
        public int cikarma(int s1, int s2,int s3)
        {
            int sonuc = 0;
            sonuc = s1 - s2 - s3;
            return sonuc;
            

        }
        public int carpma(int s1, int s2)
        {
            int sonuc = 0;
            sonuc = s1 * s2;
            return sonuc;
        }
        public int carpma(int s1, int s2,int s3)
        {
            int sonuc = 0;
            sonuc = s1 * s2 * s3;
            return sonuc;
        }
        public int carpma(int s1, int s2,int s3,int s4)
        {
            int sonuc = 0;
            sonuc = s1 * s2 * s3 * s4;
            return sonuc;
            

        }
        public int bolme(int s1)
        {
            int sonuc = 0;
            sonuc = s1;
            return sonuc;
            

        }
        public int bolme(int s1, int s2)
        {
            int sonuc = 0;
            if (s1 > s2)
            {
                sonuc = Convert.ToInt32(s1 /s2);
            }
            else
            {
                sonuc = Convert.ToInt32(s2 / s1);
            }
            return sonuc;



        }
        
    }
}
