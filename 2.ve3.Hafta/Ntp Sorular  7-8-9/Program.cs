using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntp_Sorular__7_8_9
{
    class Program
    {

        /* Soru 7.) Bir zamanlar efsanevi bir şehir olan Zarva, sayısız hazineyi saklayan devasa bir
        labirentin içinde kayboldu. Şehre ulaşabilmek için bu labirentin doğru yollarını
        çözmeniz gerekiyor. Labirent, MxN boyutlarında bir ızgaradır ve her hücrede bir
         &quot;kapı&quot; bulunur. Kapılar, sadece belirli matematiksel kuralları karşılayan
        koordinatlarda açılabilir. Eğer bir kapı açılabiliyorsa o hücreye geçiş mümkündür,
        aksi takdirde o hücreye girmek imkansızdır. Şehir haritası şu şekilde tanımlanmıştır:
        i. Labirentteki bir hücreye ancak şu şartlar sağlanırsa girebilirsiniz:
        o Hücrenin x ve y koordinatlarının her iki basamağı da asal sayı olmalıdır.
        o Eğer hem x hem de y koordinatlarının toplamı, x ve y koordinatlarının çarpımına
        bölünebiliyorsa, kapı açılacaktır.
       ii. Şehir, labirentin sağ alt köşesinde (M-1, N-1) konumunda bulunmaktadır.
       Yolculuğunuz labirentin sol üst köşesinden (0, 0) başlayacaktır. Eğer şehre
       ulaşamazsanız, kaybolursunuz.
       iii. Görev: Labirenti çözmek için bir algoritma yazmanız gerekiyor. Bu
       algoritma, belirlenen koşullara göre hangi hücrelere gidilebileceğini
       belirleyecek ve başlangıç noktasından hedef noktaya ulaşabilecek bir yol
       bulup bulamayacağını kontrol edecektir. Eğer bir yol bulabiliyorsanız, yolun
       adımlarını listeleyin. Eğer hiçbir yol yoksa, &quot;Şehir kayboldu!&quot; çıktısını verin.*/



        /* static int[] dx = { 0, 0, 1, -1 }; // Hareket yönleri (sağ, sol, aşağı, yukarı)
         static int[] dy = { 1, -1, 0, 0 };

         static void Main()
         {
             int M = 10, N = 10; // Labirent boyutları
             bool[,] ziyaretEdilen = new bool[M, N]; // Ziyaret edilen hücreleri tutar

             if (LabirentCoz(0, 0, M, N, ziyaretEdilen))
                 Console.WriteLine("Şehre ulaşıldı!");
             else
                 Console.WriteLine("Şehir kayboldu!");
         }

         static bool LabirentCoz(int x, int y, int M, int N, bool[,] ziyaretEdilen)
         {
             if (x < 0 || x >= M || y < 0 || y >= N || ziyaretEdilen[x, y] || !GecerliHareket(x, y))
                 return false;
             if (x == M - 1 && y == N - 1) return true; // Hedefe ulaşıldı
             ziyaretEdilen[x, y] = true;
             for (int i = 0; i < 4; i++)
                 if (LabirentCoz(x + dx[i], y + dy[i], M, N, ziyaretEdilen)) return true;
             return false;
         }

         static bool GecerliHareket(int x, int y)
         {
             return AsalBasamak(x) && AsalBasamak(y) && (x + y) % (x * y) == 0;
         }

         static bool AsalBasamak(int sayi)
         {
             int onlar = sayi / 10, birler = sayi % 10;
             return AsalMi(onlar) && AsalMi(birler);
         }

         static bool AsalMi(int sayi)
         {
             if (sayi < 2) return false;
             for (int i = 2; i * i <= sayi; i++)
                 if (sayi % i == 0) return false;
             return true;*/






        /* Soru 8.) Bir casus örgütü, düşmanlarının mesajlarını çözmelerini zorlaştırmak için son derece
        karmaşık bir şifreleme sistemi geliştirdi. Bu şifreleme sistemi, mesajların belirli
        kurallara göre dönüştürüldüğü bir dizi adımdan oluşuyor. Göreviniz, bu sistemi
        çözerek şifrelenmiş bir mesajın orijinal haline ulaşmaktır. Sistemin çalışma şekli şu
        kurallara dayanmaktadır:
        i. Adım 1 - Fibonacci Dönüşümü: Mesajın her bir karakteri ASCII değerine
        dönüştürülür. Daha sonra her karakterin ASCII değeri, o karakterin
        pozisyonuna göre bir Fibonacci sayısıyla çarpılır. Mesajdaki karakterlerin
        sırası 1&#39;den başlar. Yani ilk karakter, Fibonacci(1), ikinci karakter
        Fibonacci(2) ile çarpılır ve bu işlem tüm karakterler için devam eder.
        Fibonacci serisi: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
        ii. Adım 2 - Modüler Çözümleme: Fibonacci ile çarpılan her bir ASCII değeri,
        bir mod işlemine tabi tutulur. Mod işlemi şu şekilde çalışır:
        o Eğer karakterin pozisyonu asal bir sayıysa, o karakterin değeri 100&#39;e
        bölümünden kalan alınır.
        o Eğer pozisyon asal değilse, karakterin değeri 256&#39;ya bölümünden kalan
        alınır.

        iii. Adım 3 - Şifreleme: Elde edilen her mod sonucu, tekrar bir ASCII karakterine
        dönüştürülür ve yeni şifreli mesaj oluşturulur.
        iv. Görev: Size şifrelenmiş bir mesaj verilecektir. Bu mesajın çözülmesi ve
        orijinal haline geri dönülmesi gerekmektedir. Ancak şifreleme işlemi sırasında
        kullanılan Fibonacci dönüşümünü ve modüler çözümlemeyi tersine
        çevirmelisiniz. Görev, bu algoritmayı çözerek mesajı orijinaline döndürmektir.*/

        /* static void Main()
         {
             Console.WriteLine("Şifrelenmiş mesajı giriniz: ");
             string sifreliMesaj = Console.ReadLine();
             Console.WriteLine("Orijinal mesaj: " + MesajiCoz(sifreliMesaj));
         }

         static string MesajiCoz(string sifreliMesaj)
         {
             List<int> fibonacci = FibonacciDizisi(sifreliMesaj.Length);
             char[] cozulmusMesaj = new char[sifreliMesaj.Length];

             for (int i = 0; i < sifreliMesaj.Length; i++)
             {
                 int asciiDeger = sifreliMesaj[i];
                 int fibonacciCarpimi = asciiDeger * fibonacci[i];
                 int modSonucu = AsalMi(i + 1) ? fibonacciCarpimi % 100 : fibonacciCarpimi % 256;
                 cozulmusMesaj[i] = (char)modSonucu;
             }

             return new string(cozulmusMesaj);
         }

         static List<int> FibonacciDizisi(int uzunluk)
         {
             List<int> fibonacci = new List<int> { 1, 1 };
             for (int i = 2; i < uzunluk; i++)
                 fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
             return fibonacci;
         }

         static bool AsalMi(int sayi)
         {
             if (sayi < 2) return false;
             for (int i = 2; i * i <= sayi; i++)
                 if (sayi % i == 0) return false;
             return true;*/







        /* Soru 9.)  Bir grup uzay madencisi, zengin maden yataklarına sahip bir asteroide iniş yaptı.
        Ancak asteroitteki madenlerin dağılımı oldukça düzensiz ve tehlikeli yollar içeriyor.
        Maden yataklarına ulaşmak için madencilerin dikkatlice bir yol planlaması gerekiyor.
        Asteroit, NxN boyutlarında bir ızgara olarak modellenmiş durumda. Her hücre bir
        koordinata karşılık geliyor ve madenciler bu koordinatlar üzerinden maden toplamak
        zorunda. Asteroit üzerindeki maden toplama sistemi şu şekilde işliyor:
        i. Enerji harcama: Her hücrede belirli bir enerji tüketimi var. Madenciler bir
        hücreden diğerine geçerken belirli bir enerji harcarlar. Ancak bazı hücreler
        daha fazla enerji harcatır çünkü bu hücrelerde engeller, çukurlar veya volkanik

        aktiviteler olabilir. Enerji tüketimi, her hücrede farklı olup pozitif tam sayılar
        ile ifade edilmiştir.
        ii. Kısıtlamalar: Madenciler bir hücreden sadece sağa, aşağıya veya çapraz
        sağa aşağıya (diyagonal) hareket edebilirler. Geriye dönüş yoktur, bu yüzden
        planlamada bu sınırlamalara uymak zorundadırlar.
        iii. Hedef: Madenciler, (0, 0) noktasından başlayarak (N-1, N-1) noktasındaki en
        değerli madeni çıkartmak istiyorlar. Ancak bunu yaparken harcayacakları
        toplam enerji miktarını en az seviyede tutmaları gerekiyor.
        iv. Görev: Bir algoritma yazarak madencilerin (0, 0) noktasından başlayarak (N-
        1, N-1) noktasına kadar olan en az enerji harcayan yolu bulmalısınız. Enerji
        maliyeti bir 2D matriste verilecektir. Bu matrisin her hücresi, o hücrede
        harcanacak enerji miktarını göstermektedir.*/

        static void Main()
        {
            int[,] enerjiMatrisi = {
            { 1, 3, 1 },
            { 1, 5, 1 },
            { 4, 2, 1 }
        };

            int N = enerjiMatrisi.GetLength(0);
            Console.WriteLine("Minimum enerji: " + MinimumEnerji(enerjiMatrisi, N));
        }

        static int MinimumEnerji(int[,] matris, int N)
        {
            int[,] dp = new int[N, N];
            dp[0, 0] = matris[0, 0];

            for (int i = 1; i < N; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + matris[i, 0];
                dp[0, i] = dp[0, i - 1] + matris[0, i];
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1])) + matris[i, j];
                }
            }

            return dp[N - 1, N - 1];
        }
    }
}


