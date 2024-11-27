using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemCesit
{
    class Program
    {
        // İki tam sayıyı toplayan Topla fonksiyonu
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        // Üç tam sayıyı toplayan Topla fonksiyonu
        public static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        // Bir dizi tam sayıyı toplayan Topla fonksiyonu
        public static int Topla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            // İlk sürüm: İki tam sayı
            Console.WriteLine("2 + 3 = " + Topla(2, 3));

            // İkinci sürüm: Üç tam sayı
            Console.WriteLine("1 + 4 + 5 = " + Topla(1, 4, 5));

            // Üçüncü sürüm: Dizi
            int[] sayilar = { 1, 2, 3, 4 };
            Console.WriteLine("Dizi toplamı: " + Topla(sayilar));

            Console.ReadLine();
        }
    }

}
