using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup3ClassLibrary
{
    public class Grup3
    {
        public int mod_al(int sayi, int bolen)
        {
            int kalan;
            kalan = sayi % bolen;
            return kalan;
        }

        public int karesi(int sayi)
        {
            int karesi;
            karesi = sayi * sayi;
            return karesi;
        }

        public int sqrt(int sayi)
        {
            int sqrt;
            sqrt = Convert.ToInt32(Math.Sqrt(sayi));
            return sqrt;

        }

    }
}
