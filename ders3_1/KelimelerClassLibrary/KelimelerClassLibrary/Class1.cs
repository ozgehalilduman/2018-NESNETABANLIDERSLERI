using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimelerClassLibrary
{
    public class Sozluk_oge
    {
        public string kelime;
        public string aciklama;
    }
    public class Kelimeler_islem
    {
        public List<Sozluk_oge> Kelimeler=new List<Sozluk_oge>();
        public void Listele()
        {
            //yontem-3
            Kelimeler.ForEach(x=>Console.WriteLine("Kelime:{0} \t - AÇIKLAMA:{1}",x.kelime,x.aciklama));
        }
        public void Ekle(Sozluk_oge yeniK)
        {
            Kelimeler.Add(yeniK);
        }
        public void Sil(string silinecekK)
        {
            int index = Kelimeler.FindIndex(x => x.kelime == silinecekK);
            Console.WriteLine(index);
            Kelimeler.RemoveAt(index);
        }
        public void Guncelleme(string arananK, Sozluk_oge guncelK)
        {
            int index = Kelimeler.FindIndex(x => x.kelime == arananK);
            Kelimeler[index] = guncelK;
        }
    }
}
