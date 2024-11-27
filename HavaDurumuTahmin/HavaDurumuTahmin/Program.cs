using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumuTahmin
{
    // Hava durumu tiplerini temsil eden enum
    public enum WeatherType
    {
        Sunny,   // Güneşli
        Rainy,   // Yağmurlu
        Cloudy,  // Bulutlu
        Stormy   // Fırtınalı
    }

    public class WeatherAdvice
    {
        // Hava durumu tipine göre tavsiye veren metot
        public static void GiveAdvice(WeatherType weather)
        {
            switch (weather)
            {
                case WeatherType.Sunny:
                    Console.WriteLine("Bugün hava çok güzel! Güneş gözlüğü takmayı unutmayın.");
                    break;
                case WeatherType.Rainy:
                    Console.WriteLine("Hava yağmurlu. Şemsiye almayı unutmayın.");
                    break;
                case WeatherType.Cloudy:
                    Console.WriteLine("Hava bulutlu. Yanınıza bir mont almanız iyi olabilir.");
                    break;
                case WeatherType.Stormy:
                    Console.WriteLine("Fırtına var. Dışarı çıkmaktan kaçının ve güvenli bir yerde kalın.");
                    break;
                default:
                    Console.WriteLine("Geçersiz hava durumu türü.");
                    break;
            }
        }

        // Programı test etmek için main metodu
        public static void Main(string[] args)
        {
            // Farklı hava durumu türleri için tavsiyeler
            GiveAdvice(WeatherType.Sunny);
            GiveAdvice(WeatherType.Rainy);
            GiveAdvice(WeatherType.Cloudy);
            GiveAdvice(WeatherType.Stormy);

            Console.ReadLine();
        }
    }

}
