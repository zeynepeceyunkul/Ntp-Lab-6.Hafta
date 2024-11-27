using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTahtasi
{
    // Satranç tahtasını temsil eden sınıf
    public class ChessBoard
    {
        // Satranç tahtasındaki 64 kareyi 8x8 bir dizi ile temsil ediyoruz
        private string[,] board = new string[8, 8];

        // Yapıcı metod, tahtadaki tüm kareleri boş olarak başlatır
        public ChessBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = "."; // Boş kareyi temsil eder
                }
            }
        }

        // İndeksleyici ile kullanıcıların kareye taş koyabilmesini ve taşı öğrenebilmesini sağlar
        public string this[int row, int col]
        {
            get
            {
                // Geçersiz bir kareye erişim durumunda hata mesajı döndürülür
                if (row < 0 || row >= 8 || col < 0 || col >= 8)
                {
                    throw new ArgumentOutOfRangeException("Geçersiz satır veya sütun indeksidir. Satranç tahtasında 0-7 arası indeksler kullanılmalıdır.");
                }
                return board[row, col];
            }
            set
            {
                // Geçersiz bir kareye erişim durumunda hata mesajı döndürülür
                if (row < 0 || row >= 8 || col < 0 || col >= 8)
                {
                    throw new ArgumentOutOfRangeException("Geçersiz satır veya sütun indeksidir. Satranç tahtasında 0-7 arası indeksler kullanılmalıdır.");
                }
                board[row, col] = value; // İlgili kareye taş yerleştirilir
            }
        }
    }

    // Programın çalışmasını test etmek için bir ana sınıf
    public class Program
    {
        public static void Main(string[] args)
        {
            // Satranç tahtasını oluştur
            ChessBoard chessBoard = new ChessBoard();

            // Birkaç taş ekleyelim
            chessBoard[0, 0] = "R"; // Sol üst köşe, kule
            chessBoard[0, 1] = "N"; // Şövalye
            chessBoard[7, 7] = "K"; // Sağ alt köşe, şah

            // Tahtadaki bazı taşları görüntüleyelim
            Console.WriteLine("0,0: " + chessBoard[0, 0]); // Kule
            Console.WriteLine("0,1: " + chessBoard[0, 1]); // Şövalye
            Console.WriteLine("7,7: " + chessBoard[7, 7]); // Şah

            // Geçersiz bir kareye erişmeye çalışalım
            try
            {
                Console.WriteLine(chessBoard[8, 8]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
