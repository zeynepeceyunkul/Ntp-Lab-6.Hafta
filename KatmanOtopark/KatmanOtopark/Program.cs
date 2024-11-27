using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanOtopark
{
    public class Otopark
    {
        // Her kat için bir dizi oluşturuluyor.
        private string[][] katlar;

        // Yapıcı metod ile otoparkın kat sayısını ve her katın park yerlerini başlatıyoruz.
        public Otopark(int katSayisi, int parkYeriSayisi)
        {
            katlar = new string[katSayisi][];
            for (int i = 0; i < katSayisi; i++)
            {
                katlar[i] = new string[parkYeriSayisi];
                // Park yerlerini "Boş" olarak başlatıyoruz.
                for (int j = 0; j < parkYeriSayisi; j++)
                {
                    katlar[i][j] = "Boş";
                }
            }
        }

        // İndeksleyici ile belirli bir kat ve park yeri için erişim sağlıyoruz.
        public string this[int katIndex, int parkYeriIndex]
        {
            get
            {
                // Geçerli bir kat ve park yeri indeksine erişim kontrolü.
                if (katIndex < 0 || katIndex >= katlar.Length || parkYeriIndex < 0 || parkYeriIndex >= katlar[katIndex].Length)
                {
                    return "Geçersiz indeks";
                }
                return katlar[katIndex][parkYeriIndex];
            }
            set
            {
                // Geçerli bir kat ve park yeri indeksine değer ataması.
                if (katIndex < 0 || katIndex >= katlar.Length || parkYeriIndex < 0 || parkYeriIndex >= katlar[katIndex].Length)
                {
                    Console.WriteLine("Geçersiz indeks.");
                    return;
                }
                katlar[katIndex][parkYeriIndex] = value;
            }
        }

        // Park yerlerinin durumu için genel bilgi döndürme metodu.
        public void DurumGoster()
        {
            for (int i = 0; i < katlar.Length; i++)
            {
                Console.WriteLine($"Kat {i + 1}:");
                for (int j = 0; j < katlar[i].Length; j++)
                {
                    Console.WriteLine($"  Park Yeri {j + 1}: {katlar[i][j]}");
                }
            }
        }
    }

    // Programı test etmek için örnek kullanım.
    public class Program
    {
        public static void Main(string[] args)
        {
            // 3 katlı ve her katta 5 park yeri olan bir otopark oluşturuluyor.
            Otopark otopark = new Otopark(3, 5);

            // Park yerlerini dolduruyoruz.
            otopark[0, 1] = "ABC123"; // 1. kat, 2. park yeri
            otopark[1, 0] = "DEF456"; // 2. kat, 1. park yeri
            otopark[2, 4] = "GHI789"; // 3. kat, 5. park yeri

            // Park yerlerinin durumu ekrana yazdırılıyor.
            otopark.DurumGoster();

            // Belirli bir park yerini kontrol edelim.
            Console.WriteLine($"1. kat, 2. park yeri durumu: {otopark[0, 1]}");
            Console.WriteLine($"2. kat, 3. park yeri durumu: {otopark[1, 2]}");

            Console.ReadLine();
        }
    }

}
