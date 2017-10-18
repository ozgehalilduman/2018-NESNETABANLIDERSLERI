using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortislemClassLibrary
{
    public class Dortislem
    {
        public int sayi1, sayi2;
        private int sonuc;
        ///<summary>
        /// deneme
        ///<summary>
        public int toplama()
        {
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public int toplama(int s1,int s2)
        {
            sonuc = s1 + s2;
            return sonuc;
        }
        public int toplama(int s1,int s2,int s3)
        {
            sonuc = s1 + s2 + s3;
            return sonuc;
        }
    }
}
