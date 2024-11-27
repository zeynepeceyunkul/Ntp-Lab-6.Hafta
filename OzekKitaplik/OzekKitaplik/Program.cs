using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzekKitaplik
{
    public class Kitaplik
    {
        // Kitap koleksiyonunu saklamak için bir dizi tanımlıyoruz.
        private string[] kitaplar;

        // Yapıcı metod: Kitap sayısını belirten bir parametre alır ve diziyi oluşturur.
        public Kitaplik(int kitapSayisi)
        {
            kitaplar = new string[kitapSayisi];
        }

        // İndeksleyici: Belirli bir indeks ile kitaba erişimi sağlar.
        public string this[int indeks]
        {
            get
            {
                // Geçersiz indeks kontrolü.
                if (indeks < 0 || indeks >= kitaplar.Length)
                {
                    throw new ArgumentOutOfRangeException("İndeks geçersiz. Lütfen geçerli bir indeks girin.");
                }
                return kitaplar[indeks];
            }
            set
            {
                // Geçersiz indeks kontrolü.
                if (indeks < 0 || indeks >= kitaplar.Length)
                {
                    throw new ArgumentOutOfRangeException("İndeks geçersiz. Lütfen geçerli bir indeks girin.");
                }
                kitaplar[indeks] = value;
            }
        }

        // Kitaplıkta belirli bir kitabı eklemek için bir metod.
        public void KitapEkle(int indeks, string kitapAdi)
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
            {
                throw new ArgumentOutOfRangeException("İndeks geçersiz. Lütfen geçerli bir indeks girin.");
            }
            kitaplar[indeks] = kitapAdi;
        }

        // Kitapların tümünü listeleyen bir metod.
        public void KitaplariGoster()
        {
            for (int i = 0; i < kitaplar.Length; i++)
            {
                Console.WriteLine($"{i}. {kitaplar[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kitaplık oluşturuluyor ve kitaplar ekleniyor.
            Kitaplik kitaplik = new Kitaplik(5);
            kitaplik.KitapEkle(0, "C# ile Programlamaya Giriş");
            kitaplik.KitapEkle(1, "Veritabanı Yönetim Sistemleri");
            kitaplik.KitapEkle(2, "Algoritmalar ve Veri Yapıları");

            // İndeksleyici ile kitabın adı değiştiriliyor.
            kitaplik[1] = "Yüksek Performanslı Veritabanları";

            // Kitapların listesi gösteriliyor.
            kitaplik.KitaplariGoster();

            // Geçersiz bir indeks ile erişim denemesi.
            try
            {
                Console.WriteLine(kitaplik[5]); // Geçersiz indeks.
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);

            }

            Console.ReadLine();
        }
    }
}
