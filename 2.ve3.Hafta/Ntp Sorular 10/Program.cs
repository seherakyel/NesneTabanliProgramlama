using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntp_Sorular_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru 10.) Gizemli bir adada, her yıl sadece bir kez açılan efsanevi bir kapı vardır. Bu kapı,
            adanın merkezindeki bir tapınağa götürür. Ancak tapınağa ulaşmak için, kapının
            açılacağı en uygun zamanı bulmanız gerekmektedir. Kapı, belirli bir dizilimdeki
            sayılarla kilitlenmiştir ve sadece bu dizilimi doğru çözenler kapıyı açabilir.
            Bu dizilim, bir dizi sayı ve operatörlerden oluşmaktadır, ancak bu diziyi çözmek için
            belirli kurallar vardır. Diziyi doğru çözmek, sadece operatörlerin doğru sıralamasıyla
            mümkündür ve bu sıralama, sayılar arasındaki ilişkileri çözmeyi gerektirir. Adadaki
            en büyük bilge, bu diziyi çözebilecek tek kişi olduğunu söylese de çok fazla
            kombinasyon ve olasılık olduğu için kesin bir çözüm yoktur.
            Görev: Adadaki tapınağın kapısını açmak için belirli bir sayı dizisinin içerisindeki
            operatörlerin doğru sıralamasını bulmanız gerekmektedir. Ancak operatörlerin her biri
            belirli bir kurala göre hareket eder:
            i. Her sayı, bir diğer sayıya bağlanmak zorundadır.
            ii. Operatörler sadece toplama (+), çıkarma (-), çarpma (*) veya bölme (/) olabilir.
            iii. Ancak her adımda bir sayı veya operatör eklerken belirli şartlara göre hareket
            etmelisiniz. Örneğin:
            o Bir operatör eklediğinizde, en az bir sayıyı işlem görmüş hale getirmeniz gerekir.
            o İki operatör ardışık eklenemez.
            o Sonuç her zaman sıfırdan büyük olmalıdır.*/

            int[] sayilar = { 3, 5, 2, 4 };
            char[] operatorler = { '+', '-', '*', '/' };
            List<string> yollar = new List<string>();

            KapıCoz(sayilar, operatorler, "", 1, sayilar[0], yollar);

            Console.WriteLine("Geçerli yollar:");
            foreach (string yol in yollar)
                Console.WriteLine(yol);
        }

        static void KapıCoz(int[] sayilar, char[] operatorler, string yol, int index, int toplam, List<string> yollar)
        {
            if (index == sayilar.Length)
            {
                if (toplam > 0) yollar.Add(yol);
                return;
            }

            foreach (char op in operatorler)
            {
                int yeniToplam = Hesapla(toplam, sayilar[index], op);
                if (yeniToplam > 0)
                    KapıCoz(sayilar, operatorler, yol + op + sayilar[index], index + 1, yeniToplam, yollar);
            }
        }

        static int Hesapla(int a, int b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : -1; // Bölme işlemi sıfıra bölünemez
                default: return -1;
            }
        }
    }
}

