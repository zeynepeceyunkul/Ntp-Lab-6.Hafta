using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanIslem
{
    // TimeStruct adında bir yapı (struct) tanımlıyoruz.
    public struct TimeStruct
    {
        // Özellikler: saat ve dakika
        public int Hour { get; private set; }
        public int Minute { get; private set; }

        // Yapıcı metot: geçersiz saat veya dakika girildiğinde değerler 0 olarak ayarlanır.
        public TimeStruct(int hour, int minute)
        {
            // Saatin 0 ile 23 arasında olmasına, dakikanın ise 0 ile 59 arasında olmasına dikkat edilir.
            Hour = (hour >= 0 && hour < 24) ? hour : 0;
            Minute = (minute >= 0 && minute < 60) ? minute : 0;
        }

        // Zamanın toplam dakika değerini döndüren metot
        public int GetTotalMinutes()
        {
            return (Hour * 60) + Minute;
        }

        // İki zaman nesnesi arasındaki farkı (dakika olarak) hesaplayan metot
        public static int GetDifferenceInMinutes(TimeStruct time1, TimeStruct time2)
        {
            int totalMinutes1 = time1.GetTotalMinutes();
            int totalMinutes2 = time2.GetTotalMinutes();
            return Math.Abs(totalMinutes1 - totalMinutes2);
        }
    }

    // Örnek kullanım
    public class Program
    {
        public static void Main(string[] args)
        {
            // Geçerli bir zaman nesnesi oluşturuluyor
            TimeStruct time1 = new TimeStruct(15, 30); // 15 saat 30 dakika
            TimeStruct time2 = new TimeStruct(18, 45); // 18 saat 45 dakika
            TimeStruct time3 = new TimeStruct(25, 61); // Geçersiz giriş, saat ve dakika 0 yapılacak

            Console.WriteLine("Zaman 1: {0} saat ve {1} dakika", time1.Hour, time1.Minute);
            Console.WriteLine("Zaman 2: {0} saat ve {1} dakika", time2.Hour, time2.Minute);
            Console.WriteLine("Zaman 3 (Geçersiz Giriş): {0} saat ve {1} dakika", time3.Hour, time3.Minute);

            Console.WriteLine("Zaman 1'in toplam dakikası: " + time1.GetTotalMinutes());
            Console.WriteLine("Zaman 2'nin toplam dakikası: " + time2.GetTotalMinutes());
            Console.WriteLine("Zaman 1 ile Zaman 2 arasındaki fark (dakika cinsinden): " + TimeStruct.GetDifferenceInMinutes(time1, time2));

            Console.ReadLine();
        }

    }
}
