using System;

class Program
{
    static int[,] alan = new int[20, 20];
    static bool[,] acilan = new bool[20, 20];
    static int toplamMayin = 40;

    static void Main()
    {
        Console.WriteLine("Mayın Tarlası'na Hoş Geldiniz!");
        MayinlariYerlestir();
        Oyna();
    }

    static void MayinlariYerlestir()
    {
        Random rnd = new Random();
        int yerlestirilen = 0;

        while (yerlestirilen < toplamMayin)
        {
            int x = rnd.Next(20), y = rnd.Next(20);
            if (alan[x, y] == 0)
            {
                alan[x, y] = 1;
                yerlestirilen++;
            }
        }
    }

    static void Oyna()
    {
        while (true)
        {
            TahtayiGoster();
            Console.Write("Satır Sütun: ");
            string[] girdi = Console.ReadLine().Split();
            int x = int.Parse(girdi[0]), y = int.Parse(girdi[1]);

            if (alan[x, y] == 1)
            {
                Console.WriteLine("Mayına bastınız! Oyun bitti.");
                break;
            }

            HucroyuAc(x, y);

            if (KazanmaKontrol())
            {
                Console.WriteLine("Tebrikler! Kazandınız!");
                break;
            }
        }
    }

    static void TahtayiGoster()
    {
        Console.Clear();
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.Write(acilan[i, j] ? (alan[i, j] == 1 ? "*" : ".") : "#");
            }
            Console.WriteLine();
        }
    }

    static void HucroyuAc(int x, int y)
    {
        if (x < 0 || y < 0 || x >= 20 || y >= 20 || acilan[x, y]) return;

        acilan[x, y] = true;

        if (CevreMayinSay(x, y) == 0)
        {
            for (int dx = -1; dx <= 1; dx++)
                for (int dy = -1; dy <= 1; dy++)
                    HucroyuAc(x + dx, y + dy);
        }
    }

    static int CevreMayinSay(int x, int y)
    {
        int say = 0;
        for (int dx = -1; dx <= 1; dx++)
            for (int dy = -1; dy <= 1; dy++)
            {
                int nx = x + dx, ny = y + dy;
                if (nx >= 0 && ny >= 0 && nx < 20 && ny < 20 && alan[nx, ny] == 1)
                    say++;
            }
        return say;
    }

    static bool KazanmaKontrol()
    {
        for (int i = 0; i < 20; i++)
            for (int j = 0; j < 20; j++)
                if (alan[i, j] == 0 && !acilan[i, j])
                    return false;
        return true;
        Console.ReadLine();
    }
}
