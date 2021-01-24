using System;

namespace Sorunlar
{
    class sorunlarprogram
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun) ;
            {
                Console.WriteLine("Artış  Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
        }
    }
}
