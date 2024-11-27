using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarkliSekilAlan
{
    class Program
    {
        // Kare alanını hesaplayan metot
        public static double Alan(double kenar)
        {
            // Alan = kenar * kenar
            return kenar * kenar;
        }

        // Dikdörtgen alanını hesaplayan metot
        public static double Alan(double uzunKenar, double kisaKenar)
        {
            // Alan = uzun kenar * kısa kenar
            return uzunKenar * kisaKenar;
        }

        // Daire alanını hesaplayan metot
        public static double Alan(double yaricap, bool daire)
        {
            // Alan = π * yarıçap^2
            // Math.PI ile π sabitini kullanıyoruz
            return Math.PI * yaricap * yaricap;
        }

        static void Main(string[] args)
        {
            // Kare örneği
            double kareAlan = Alan(5);
            Console.WriteLine("Karenin Alanı: " + kareAlan);

            // Dikdörtgen örneği
            double dikdortgenAlan = Alan(7, 4);
            Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgenAlan);

            // Daire örneği
            double daireAlan = Alan(3, true);
            Console.WriteLine("Dairenin Alanı: " + daireAlan);

            Console.ReadLine();
        }
    }

}
