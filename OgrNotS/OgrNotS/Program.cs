using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrNotS
{
    public class StudentGrades
    {
        // Ders isimlerini ve notlarını depolamak için bir sözlük (dictionary) kullanıyoruz.
        private Dictionary<string, int> grades;

        // Yapıcı metod (constructor) ile sınıfı başlatıyoruz.
        public StudentGrades()
        {
            grades = new Dictionary<string, int>();
        }

        // İndeksleyici (indexer) aracılığıyla ders adına göre notlara erişim sağlıyoruz.
        public int this[string course]
        {
            get
            {
                // Eğer ders sözlükte varsa, notu döndür.
                if (grades.ContainsKey(course))
                {
                    return grades[course];
                }
                else
                {
                    // Ders yoksa hata mesajı döndür.
                    throw new KeyNotFoundException("Ders bulunamadı: " + course);
                }
            }
            set
            {
                // Dersin notunu sözlüğe ekliyoruz veya mevcutsa güncelliyoruz.
                grades[course] = value;
            }
        }

        // Not eklemek için yardımcı bir metod.
        public void AddGrade(string course, int grade)
        {
            grades[course] = grade;
        }

        // Tüm dersleri ve notları yazdıran metod.
        public void PrintAllGrades()
        {
            foreach (var entry in grades)
            {
                Console.WriteLine("Ders: " + entry.Key + ", Not: " + entry.Value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // StudentGrades sınıfını oluşturuyoruz.
            StudentGrades student = new StudentGrades();

            // Ders ve notları ekliyoruz.
            student["Matematik"] = 85;
            student["Fizik"] = 90;
            student["Kimya"] = 78;

            // Notları yazdırıyoruz.
            student.PrintAllGrades();

            // Belirli bir dersin notunu ekrana yazdırma.
            try
            {
                Console.WriteLine("Matematik notu: " + student["Matematik"]);
                Console.WriteLine("Biyoloji notu: " + student["Biyoloji"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

}
