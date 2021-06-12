using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaD_ZAD2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesena vrijednost:");



            int vrijednost = 100;



            bool b = true;
            KlasaD SuprotniPrvi = new KlasaD();

            KlasaD SuprotniDrugi = new KlasaD();

            Console.WriteLine("bool " + SuprotniPrvi.SuprotnoPrvi(b) + ", broj " + SuprotniPrvi.SuprotnoDrugi(vrijednost));
            Console.ReadKey();


        }
    }
}
