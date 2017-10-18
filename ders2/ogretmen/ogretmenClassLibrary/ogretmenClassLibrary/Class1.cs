using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogretmenClassLibrary
{
    /// <summary>
    /// ders2 sınıfım
    /// </summary>
    public class OgretmenClass
    {
        /// <summary>
        /// girilen degerleri tutacak 
        /// </summary>
        private List<int> sayilar;
        public OgretmenClass()
        {
            sayilar = new List<int>();
            Console.Write("\t****\t DERS 2\t****");
        }
        public void Degergir()
        {
            string deger;
            Console.Write("Deger Giriniz\t");
            deger = Console.ReadLine();
            sayilar.Add(Convert.ToInt32(deger));
        }
        public void GirilenDegerler()
        {
            for (int i = 0; i < sayilar.Count; i++)
                Console.WriteLine(sayilar[i]);
        }

           
    }
}
