using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpsKonum
{
    // GPS konumunu temsil eden bir struct
    public struct GPSLocation
    {
        public double Latitude { get; set; } // Enlem
        public double Longitude { get; set; } // Boylam

        // Constructor ile enlem ve boylam bilgilerini ayarlama
        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // İki GPS konumu arasındaki mesafeyi hesaplayan metot
        public double CalculateDistance(GPSLocation otherLocation)
        {
            // Yarı çapı kilometre cinsinden olan Dünya'nın ortalama yarıçapı
            const double EarthRadius = 6371.0;

            // Enlem ve boylamları radyan cinsine çevirme
            double lat1 = DegreeToRadian(this.Latitude);
            double lon1 = DegreeToRadian(this.Longitude);
            double lat2 = DegreeToRadian(otherLocation.Latitude);
            double lon2 = DegreeToRadian(otherLocation.Longitude);

            // Haversine Formülü ile iki nokta arasındaki mesafeyi hesaplama
            double dlat = lat2 - lat1;
            double dlon = lon2 - lon1;

            double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dlon / 2) * Math.Sin(dlon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Mesafe hesaplama
            double distance = EarthRadius * c;
            return distance;
        }

        // Dereceyi radyana çevirme metodu
        private double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }
    }

    // Kullanım örneği
    class Program
    {
        static void Main(string[] args)
        {
            GPSLocation location1 = new GPSLocation(52.5200, 13.4050); // Berlin
            GPSLocation location2 = new GPSLocation(48.8566, 2.3522);  // Paris

            double distance = location1.CalculateDistance(location2);
            Console.WriteLine("Berlin ile Paris arasındaki mesafe: " + distance.ToString("F2") + " km");

            Console.ReadLine();
        }
    }
}
