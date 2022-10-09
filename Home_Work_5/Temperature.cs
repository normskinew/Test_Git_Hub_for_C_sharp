using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_5
{
    public class Temperature
    {
        public static void CelsiumFromFar(double F)
        {
           double C = (F - 32) / 1.8;
           Console.WriteLine("Celsium={0:f2} ", C);
        }
        public static void FarenhaitFromCel( double C)
        {
            double F = 1.8 * C + 32;
            Console.WriteLine("Fahrenhait={0:f2} ", F);

        }
        public static void CelsiumFromKel(double K)
        {
            double C = K - 273.15f;
            Console.WriteLine("Celsium={0:f2} ", C);
        }

        public static void KelvinFromCel(double C)
        {
            double K = C + 273.15f;
            Console.WriteLine("Kelvin={0:f2} ",K);
        }
        public static void KelvinFromFar(double F)
        {
            double K = (F - 32) / 1.8 + 273.15;
            Console.WriteLine("Kelvin={0:f2} ", K);
        }
        public static void FarenheitFromKel(double K)
        {
            double F = (K - 32) / 1.8 - 273.15;
            Console.WriteLine("Fahrenhait={0:f2} ", F);
        }















    }
}
