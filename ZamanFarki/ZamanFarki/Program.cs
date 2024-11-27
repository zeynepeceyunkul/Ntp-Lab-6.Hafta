using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanFarki
{
    public class DateDifferenceCalculator
    {
        // İlk sürüm: İki tarih arasındaki farkı gün cinsinden döndürme
        public static int GetDifferenceInDays(DateTime date1, DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            return Math.Abs(difference.Days);
        }

        // İkinci sürüm: İki tarih arasındaki farkı saat cinsinden döndürme
        public static int GetDifferenceInHours(DateTime date1, DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            return (int)Math.Abs(difference.TotalHours);
        }

        // Üçüncü sürüm: İki tarih arasındaki farkı yıl, ay ve gün cinsinden döndürme
        public static (int years, int months, int days) GetDifferenceInYearsMonthsDays(DateTime date1, DateTime date2)
        {
            // Tarihleri karşılaştırmadan önce en eski tarihi date1 olarak ayarlayın
            if (date1 > date2)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;

            if (days < 0)
            {
                months--;
                DateTime previousMonthDate = date2.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonthDate.Year, previousMonthDate.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            return (years, months, days);
        }

        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2020, 5, 15);
            DateTime date2 = new DateTime(2023, 11, 27);

            // Gün cinsinden fark
            Console.WriteLine("Gün cinsinden fark: " + GetDifferenceInDays(date1, date2));

            // Saat cinsinden fark
            Console.WriteLine("Saat cinsinden fark: " + GetDifferenceInHours(date1, date2));

            // Yıl, ay ve gün cinsinden fark
            var difference = GetDifferenceInYearsMonthsDays(date1, date2);
            Console.WriteLine("Yıl, ay ve gün cinsinden fark: " +
                              $"{difference.years} yıl, {difference.months} ay, {difference.days} gün");
        }
    }

}
