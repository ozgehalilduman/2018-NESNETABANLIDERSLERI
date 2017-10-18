using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ogretmenClassLibrary;

namespace ogretmenConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OgretmenClass ogrt = new OgretmenClass();
            ogrt.Degergir();
            ogrt.Degergir();
            ogrt.Degergir();
            ogrt.GirilenDegerler();
            ogrt.Degergir();
            ogrt.Degergir();
            ogrt.GirilenDegerler();
            Console.ReadKey();
        }
    }
}
