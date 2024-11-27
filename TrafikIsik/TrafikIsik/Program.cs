using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikIsik
{
    // Enum, trafik ışıklarının durumlarını temsil eder.
    public enum TrafficLight
    {
        Red,    // Kırmızı ışık - durmayı ifade eder.
        Yellow, // Sarı ışık - dikkatli olunmalı ve hazırlık yapılmalı.
        Green   // Yeşil ışık - geçiş için güvenli.
    }

    public class TrafficLightController
    {
        // Bu metot, trafik ışığının durumuna göre ne yapılması gerektiğini döner.
        public string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Kırmızı ışık: Dur!";
                case TrafficLight.Yellow:
                    return "Sarı ışık: Dikkat et, hazırlık yap!";
                case TrafficLight.Green:
                    return "Yeşil ışık: Geç!";
                default:
                    return "Geçersiz ışık durumu.";
            }
        }
    }

    // Program sınıfı, örneği çalıştırmak için kullanılır.
    class Program
    {
        static void Main(string[] args)
        {
            // Trafik ışığı kontrolörü oluşturuluyor.
            TrafficLightController controller = new TrafficLightController();

            // Örnek bir trafik ışığı durumu belirleniyor.
            TrafficLight currentLight = TrafficLight.Green;

            // Duruma göre ne yapılması gerektiği yazdırılıyor.
            Console.WriteLine(controller.GetAction(currentLight));

            Console.ReadLine();
        }
    }
}
