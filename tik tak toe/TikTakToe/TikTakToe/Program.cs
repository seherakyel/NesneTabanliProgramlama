using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] tahta = new char[3, 3];
        static char oyuncu = 'X';

        static void Main(string[] args)
        {
            TahtaSifirla();
            int hamleSayisi = 0;

            while (true)
            {
                Console.Clear();
                TahtaYazdir();
                Console.WriteLine("Oyuncu {0}, satır ve sütun gir (1-3): ", oyuncu);
                int satir = int.Parse(Console.ReadLine()) - 1;
                int sutun = int.Parse(Console.ReadLine()) - 1;

                if (tahta[satir, sutun] == ' ')
                {
                    tahta[satir, sutun] = oyuncu;
                    hamleSayisi++;
                }
                else
                {
                    Console.WriteLine("Geçersiz hamle! Tekrar deneyin.");
                    Console.ReadKey();
                    continue;
                }

                if (KazananKontrol())
                {
                    Console.Clear();
                    TahtaYazdir();
                    Console.WriteLine("Oyuncu {0} kazandı!", oyuncu);
                    break;
                }
                else if (hamleSayisi == 9)
                {
                    Console.Clear();
                    TahtaYazdir();
                    Console.WriteLine("Berabere!");
                    break;
                }

                oyuncu = (oyuncu == 'X') ? 'O' : 'X';
            }
            Console.ReadLine();
        }

        static void TahtaSifirla()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tahta[i, j] = ' ';
        }

        static void TahtaYazdir()
        {
            Console.WriteLine("  1 2 3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + tahta[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool KazananKontrol()
        {
            // Satır kontrolü
            for (int i = 0; i < 3; i++)
                if (tahta[i, 0] == oyuncu && tahta[i, 1] == oyuncu && tahta[i, 2] == oyuncu)
                    return true;

            // Sütun kontrolü
            for (int i = 0; i < 3; i++)
                if (tahta[0, i] == oyuncu && tahta[1, i] == oyuncu && tahta[2, i] == oyuncu)
                    return true;

            // Çapraz kontrolü
            if (tahta[0, 0] == oyuncu && tahta[1, 1] == oyuncu && tahta[2, 2] == oyuncu)
                return true;
            if (tahta[0, 2] == oyuncu && tahta[1, 1] == oyuncu && tahta[2, 0] == oyuncu)
                return true;

            return false;
        }
    }
}
