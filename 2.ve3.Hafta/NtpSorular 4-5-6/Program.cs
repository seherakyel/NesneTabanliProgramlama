using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NtpSorular_4_5_6
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Soru 4.)  Kullanıcının girdiği matematiksel ifadeyi (örneğin, 3 + 4 * 2 / (1 - 5) ^ 2 ^ 3) işlem
             önceliklerine göre çözümleyen bir program yazın. Program, sonucu yazdırmadan önce
             ifadenin çözüm sürecini açıklamalıdır (hangi işlemlerin hangi sırayla yapıldığını gösterin)*/

             /*   Console.WriteLine("Bir matematiksel ifade giriniz: ");
                string ifade = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ifade)) return;

                var postfix = InfixToPostfix(ifade);
                Console.WriteLine("Sonuç: " + EvaluatePostfix(postfix));
            }

            static double EvaluatePostfix(List<string> postfix)
            {
                Stack<double> stack = new Stack<double>();
                foreach (string t in postfix)
                {
                    if (double.TryParse(t, out double num))
                        stack.Push(num);
                    else
                    {
                        double b = stack.Pop(), a = stack.Pop();
                        stack.Push(t == "+" ? a + b : t == "-" ? a - b : t == "*" ? a * b : t == "/" ? a / b : Math.Pow(a, b));
                    }
                }
                return stack.Pop();
            }

            static List<string> InfixToPostfix(string ifade)
            {
                Stack<string> stack = new Stack<string>();
                List<string> output = new List<string>();
                foreach (Match m in Regex.Matches(ifade, @"(\d+\.?\d*)|([\+\-\*/     // \^\(\)])"))
             /*   {
                    string t = m.Value;
                    if (double.TryParse(t, out _))
                        output.Add(t);
                    else if (t == "(")
                        stack.Push(t);
                    else if (t == ")")
                    {
                        while (stack.Peek() != "(")
                            output.Add(stack.Pop());
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(t))
                            output.Add(stack.Pop());
                        stack.Push(t);
                    }
                }
                while (stack.Count > 0) output.Add(stack.Pop());
                return output;
            }

            static int Precedence(string op) => op == "+" || op == "-" ? 1 : op == "*" || op == "/" ? 2 : 3; */
        }








               /*  Soru 5.) Kullanıcıdan iki polinom girmesini isteyin (örneğin, 2x^2 + 3x - 5 ve x^2 - 4).
               Program, bu iki polinomu toplayıp ve çıkararak sonuçları göstermelidir. Kullanıcı,
               exit yazarak işlemi sonlandırana kadar yeni polinomlar girmeye devam etsin.*/

       
     /*        while (true)
            {
                Console.WriteLine("Birinci polinomu giriniz (Çıkmak için 'exit' yazın):");
                string polinom1 = Console.ReadLine();
                if (polinom1.ToLower() == "exit") break;

                Console.WriteLine("İkinci polinomu giriniz (Çıkmak için 'exit' yazın):");
                string polinom2 = Console.ReadLine();
                if (polinom2.ToLower() == "exit") break;

                Dictionary<int, int> p1 = ParsePolinom(polinom1);
                Dictionary<int, int> p2 = ParsePolinom(polinom2);

                Console.WriteLine("Toplam:");
                YazdirPolinom(ToplaPolinom(p1, p2));
                Console.WriteLine("Fark:");
                YazdirPolinom(CikarPolinom(p1, p2));
            }
        }

        static Dictionary<int, int> ParsePolinom(string polinom)
        {
            Dictionary<int, int> terimler = new Dictionary<int, int>();
            MatchCollection matches = Regex.Matches(polinom.Replace(" ", ""), @"([+-]?\d*)x\^(\d+)|([+-]?\d*)x|([+-]?\d+)");
            foreach (Match match in matches)
            {
                int katsayi = int.Parse(match.Groups[1].Success ? (match.Groups[1].Value == "" ? "1" : match.Groups[1].Value) : (match.Groups[3].Success ? match.Groups[3].Value : match.Groups[4].Value));
                int derece = match.Groups[2].Success ? int.Parse(match.Groups[2].Value) : match.Groups[3].Success ? 1 : 0;
                if (terimler.ContainsKey(derece)) terimler[derece] += katsayi;
                else terimler[derece] = katsayi;
            }
            return terimler;
        }

        static Dictionary<int, int> ToplaPolinom(Dictionary<int, int> p1, Dictionary<int, int> p2)
        {
            foreach (KeyValuePair<int, int> terim in p2)
            {
                if (p1.ContainsKey(terim.Key)) p1[terim.Key] += terim.Value;
                else p1[terim.Key] = terim.Value;
            }
            return p1;
        }

        static Dictionary<int, int> CikarPolinom(Dictionary<int, int> p1, Dictionary<int, int> p2)
        {
            foreach (KeyValuePair<int, int> terim in p2)
            {
                if (p1.ContainsKey(terim.Key)) p1[terim.Key] -= terim.Value;
                else p1[terim.Key] = -terim.Value;
            }
            return p1;
        }

        static void YazdirPolinom(Dictionary<int, int> polinom)
        {
            List<string> terimler = new List<string>();
            foreach (KeyValuePair<int, int> terim in polinom)
            {
                if (terim.Value != 0)
                {
                    if (terim.Key == 0) terimler.Add($"{terim.Value}");
                    else if (terim.Key == 1) terimler.Add($"{terim.Value}x");
                    else terimler.Add($"{terim.Value}x^{terim.Key}");
                }
            }
            Console.WriteLine(string.Join(" + ", terimler));  */
        }
    }






    /*Bir grup bilim insanı, insanları zamanda geriye götürebilecek bir cihaz geliştirdi.
      Ancak bu cihazı kullanmak için doğru tarih ve saat koordinatlarını çözmek gerekiyor.
      Cihazın çalışma mantığına göre, tarihin gün, ay ve yıl bileşenleri birbiriyle
      matematiksel olarak ilişkilendirilmiş durumda. Bir zaman yolcusu, geçmişe gitmek
      için cihazı kullanmak istiyor, ancak cihazın gideceği tarihi doğru bir şekilde çözmesi
      gerekiyor. Bilim insanları bu zaman yolcusuna cihazın algoritmasını anlaması için
      bazı ipuçları verdi:
      i. Gün, ay ve yıl ilişkisi: Cihaz yalnızca belirli tarih formatında çalışıyor. Bir
      tarih (gün, ay, yıl) cihazın kabul edeceği formattaysa, zamanda yolculuk
      mümkün oluyor. Kabul edilen formattaki bir tarihin, aşağıdaki koşullara
      uyması gerekiyor:
       Gün sayısı asal sayı olmalı.
       Ay sayısının tüm basamaklarının toplamı çift olmalı.
       Yıl sayısı ise şu özelliğe sahip olmalı: Yıl sayısını oluşturan rakamlar
      toplamı, o yılın dörtte birinden küçük olmalı.
      ii. Algoritmik zorluklar: Zaman yolcusu, 2000 ile 3000 yılları arasında bir
      tarihe gitmek istiyor. Ona cihazın kabul ettiği tüm uygun tarihleri listeleyen bir
      algoritma yazması gerektiği söyleniyor. Ancak milyonlarca olası tarih
      kombinasyonu olduğu için, algoritmanın verimli çalışması gerekiyor.
      iii. Ek koşullar: Zaman yolcusunun yalnızca geleceğe gitmesine izin veriliyor.
      Bu yüzden algoritma, şu andan sonraki bir tarihe odaklanmalı.
      iv. Görev: Zaman yolcusuna yardım etmek için bir algoritma yaz. Bu algoritma,
      belirlenen tarihler aralığında cihazın kabul edeceği tüm geçerli tarihleri
      listelemelidir. Her tarih, gün, ay ve yıl formatında olmalı. Cihazın kabul ettiği
      tarihler listeye eklenmelidir.*/

    /* for (int yil = 2000; yil <= 3000; yil++)
     {
         for (int ay = 1; ay <= 12; ay++)
         {
             int gunSayisi = GunSayisi(ay, yil);
             for (int gun = 1; gun <= gunSayisi; gun++)
             {
                 if (AsalMi(gun) && AyBasamakToplamCift(ay) && YilKuraliSaglarMi(yil))
                 {
                     Console.WriteLine($"{gun}/{ay}/{yil}");
                 }
             }
         }
     }
 }

 static int GunSayisi(int ay, int yil)
 {
     if (ay == 2)
         return (yil % 4 == 0 && (yil % 100 != 0 || yil % 400 == 0)) ? 29 : 28;
     return (ay == 4 || ay == 6 || ay == 9 || ay == 11) ? 30 : 31;
 }

 static bool AsalMi(int sayi)
 {
     if (sayi < 2) return false;
     for (int i = 2; i * i <= sayi; i++)
         if (sayi % i == 0) return false;
     return true;
 }

 static bool AyBasamakToplamCift(int ay)
 {
     int toplam = 0;
     while (ay > 0)
     {
         toplam += ay % 10;
         ay /= 10;
     }
     return toplam % 2 == 0;
 }

 static bool YilKuraliSaglarMi(int yil)
 {
     int rakamToplami = 0, tempYil = yil;
     while (tempYil > 0)
     {
         rakamToplami += tempYil % 10;
         tempYil /= 10;
     }
     return rakamToplami < yil / 4;*/
}
        }




    }

