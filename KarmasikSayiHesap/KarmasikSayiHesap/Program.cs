using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmasikSayiHesap
{
    // Karmaşık sayıları temsil eden struct
    public struct ComplexNumber
    {
        // Gerçek ve sanal kısımları temsil eden özellikler
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Yapıcı metot
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Toplama işlemini gerçekleştiren metot
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Çıkarma işlemini gerçekleştiren metot
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        // Karmaşık sayıyı "a + bi" formatında döndüren ToString metodu
        public override string ToString()
        {
            // Gerçek ve sanal kısımlar arasında " + " sembolünü koyma
            return $"{Real} + {Imaginary}i";
        }
    }

    // Program sınıfı ile test
    public class Program
    {
        public static void Main()
        {
            // Örnek karmaşık sayılar
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);

            // Toplama işlemini test etme
            ComplexNumber sum = c1 + c2;
            Console.WriteLine("Toplam: " + sum);

            // Çıkarma işlemini test etme
            ComplexNumber difference = c1 - c2;
            Console.WriteLine("Fark: " + difference);

            Console.ReadLine();
        }
    }
}
