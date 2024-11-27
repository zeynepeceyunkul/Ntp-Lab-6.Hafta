using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanRolMaas
{
    // Çalışan rolleri için bir enum oluşturuluyor.
    public enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    public class SalaryCalculator
    {
        // Enum'a göre maaşı hesaplayan bir metot.
        public static decimal CalculateSalary(EmployeeRole role)
        {
            // Her role için maaş belirleniyor.
            switch (role)
            {
                case EmployeeRole.Manager:
                    return 10000m; // Yöneticilerin maaşı 10.000 birim.
                case EmployeeRole.Developer:
                    return 8000m;  // Geliştiricilerin maaşı 8.000 birim.
                case EmployeeRole.Designer:
                    return 7000m;  // Tasarımcıların maaşı 7.000 birim.
                case EmployeeRole.Tester:
                    return 6000m;  // Testçilerin maaşı 6.000 birim.
                default:
                    throw new ArgumentException("Geçersiz çalışan rolü.");
            }
        }

        public static void Main(string[] args)
        {
            // Kullanıcıdan bir çalışan rolü seçmesi isteniyor.
            Console.WriteLine("Bir çalışan rolü seçin (Manager, Developer, Designer, Tester):");
            string input = Console.ReadLine();

            // Girilen verinin enum türüne dönüştürülmesi.
            if (Enum.TryParse(input, true, out EmployeeRole role))
            {
                // Maaş hesaplanıyor ve ekrana yazdırılıyor.
                decimal salary = CalculateSalary(role);
                Console.WriteLine($"{role} için maaş: {salary} birim.");
            }
            else
            {
                Console.WriteLine("Geçersiz bir rol girdiniz.");
            }

            Console.ReadLine();
        }
    }
}
