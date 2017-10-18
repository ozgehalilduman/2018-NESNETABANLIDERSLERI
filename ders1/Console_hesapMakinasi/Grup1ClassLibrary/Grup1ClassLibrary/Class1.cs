using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup1ClassLibrary
{
    public class Grup1
    {
        public void temizyaz(int sonuc)
        {
            Console.Write("SONUC =");
            Console.Write(sonuc);
            Console.ReadKey();
        }

        public void RenkliYaz(int sonuc)
        {
            Console.Write("SONUC =");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
        public void ArkaFondegistirYaz(int sonuc)
        {
            Console.Write("SONUC =");
            Console.BackgroundColor = ConsoleColor.Red;           
            Console.Write(sonuc);
            Console.ReadKey();

       }
    }
}
