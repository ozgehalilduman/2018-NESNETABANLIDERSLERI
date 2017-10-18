using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRUP1ClassLibrary
{
    /// <summary>
    ///  GRUB1 in Hazırladıgı sınıf
    /// </summary>
    public class Grub1class
    {
        /// <summary>
        /// toplama yapmaya yarayan metod
        /// </summary>
        /// <param name="s1">Sayi1 olacak tam sayi değişkeni</param>
        /// <param name="s2">Sayi2 olacak tam sayi değişkeni</param>
        /// <returns>Geriye tam sayi döndürür</returns>
        public int topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        /// <summary>
        /// 3 sayıyı toplamaya yarayan metod
        /// </summary>
        /// <param name="s1">sayi1 olacak tam sayi değişkeni</param>
        /// <param name="s2">sayi2 olacak tam sayi değişkeni</param>
        /// <param name="s3">sayi3 olacak tam sayi değişkeni</param>
        /// <returns></returns>
        public int topla(int s1, int s2, int s3)
        {
            int sonuc = s1 + s2 + s3;
            return sonuc;
        }
        /// <summary>
        /// Cikarma yapmaya yaryan metod
        /// </summary>
        /// <param name="s1">sayi1 olacak tam sayi değişkeni</param>
        /// <param name="s2">sayi2 olacak tam sayi değişkeni</param>
        /// <returns></returns>
        public int cikarma(int s1, int s2)
        {
            int sonuc = s1 - s2;
            return sonuc;
        }
        /// <summary>
        /// Carpma yapmaya yarayan metod
        /// </summary>
        /// <param name="s1">sayi1 olacak tam sayi değişkeni</param>
        /// <param name="s2">sayi2 olacak tam sayi değişkeni</param>
        /// <returns></returns>
        public int carp(int s1, int s2)
        {
            int sonuc = s1 * s2;
            return sonuc;
        }
        public int carp(List<int> sayilar)
        {
            int sonuc = 1;
            for (int i = 0; i < sayilar.Count; i++) 
            {
                sonuc *= sayilar[i];
            }
            return sonuc;

        }

        /// <summary>
        /// Bolme yapmaya yarayan metod
        /// </summary>
        /// <param name="s1">sayi1 olacak tam sayi değişkeni</param>
        /// <param name="s2">sayi2 olacak tam sayi değişkeni</param>
        /// <returns></returns>
        public int bolme(int s1, int s2)
        {
            int sonuc = s1 / s2;
            return sonuc;
        }

    }
}
