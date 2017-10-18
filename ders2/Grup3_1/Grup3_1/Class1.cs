using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup3
{
    public class Grup3Class
    {
        private List<int> degerler;
        public Grup3Class()
        {
            degerler = new List<int>();
        }
        public void DegerGir()
        {
            string deger;
            Console.Write("DegerGir Gir\t");
            deger=Console.ReadLine();
            degerler.Add(Int32.Parse(deger));
        }
        public List<int> DegerleriAl()
        {
            return degerler;
        }
        /// <summary>
        /// ekrana yazdiran method
        /// </summary>
        /// <param name="sonuc">ekrana yazdirir</param>
        public void Ekranyaz(int sonuc)
        {
            Console.WriteLine(sonuc);
        }
        public void Ekranyaz()
        {
            for (int i = 0; i < degerler.Count; i++)
            {
                Console.WriteLine(degerler[i]);
            }
        }
		public void Ekranyaz(List<int> sonuclar)
        {
            for (int i = 0; i < sonuclar.Count; i++)
            {
                Console.WriteLine(sonuclar[i]);
            }
        }
        /// <summary>
        /// Ekrana renkli yazdiran method 
        /// </summary>
        /// <param name="sonuc">ekrana renkli yazdirir</param>
        /// <param name="renk">Console color method(foreground)</param>
        //change font color
        public void Renkliyaz(int sonuc,ConsoleColor renk )
        {
            Console.ForegroundColor = renk;
            Console.WriteLine(sonuc);
        }
        /// <summary>
        /// Ekrana Arkasi renkli yazdiran Method
        /// </summary>
        /// <param name="sonuc">Ekrana Arkasi renkli yazdirir</param>
        /// <param name="renk">Console color method(backgroud)</param>
        //change backgroundcolor
        public void Arkasirenkliyaz(int sonuc, ConsoleColor renk)
        {
            Console.BackgroundColor = renk;
            Console.WriteLine(sonuc);
        }
    

    }
}
