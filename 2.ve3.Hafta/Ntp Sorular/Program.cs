using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Ntp_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru 1.) Kullanıcıdan bir dizi tam sayı alın ve bu sayıları sıralayın. Ardından, kullanıcıdan bir
             sayı alın ve bu sayının dizide olup olmadığını ikili arama algoritması ile kontrol edin.
             Sonucu ekrana yazdırın. */

            // Kullanıcıdan dizi elemanlarını alma
            Console.WriteLine("Lütfen tam sayılar dizisini boşluk ile ayırarak giriniz:");
            string input = Console.ReadLine(); // Kullanıcıdan dizi elemanlarını al
            string[] inputArray = input.Split(' '); // Boşluklara göre diziyi parçala
            int[] numbers = Array.ConvertAll(inputArray, int.Parse); // String dizisini int dizisine çevir

            // Diziyi sıralama
            Array.Sort(numbers); // Dizi küçükten büyüğe sıralanıyor
            Console.WriteLine("Sıralanmış dizi: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " "); // Sıralanmış diziyi yazdır
            }
            Console.WriteLine(); // Bir satır boşluk bırak

            // Kullanıcıdan aramak istediği sayıyı alma
            Console.WriteLine("Lütfen aramak istediğiniz sayıyı giriniz:");
            int target = int.Parse(Console.ReadLine());

            // İkili arama algoritması ile arama
            int result = Array.BinarySearch(numbers, target);

            // Sonuç yazdırma
            if (result >= 0)
            {
                Console.WriteLine("Sayı dizide bulundu.");
            }
            else
            {
                Console.WriteLine("Sayı dizide bulunamadı.");
            }

            Console.ReadLine(); // Programı kapatmadan önce bekle




            /* Soru 2.) Kullanıcıdan pozitif tam sayılar alarak, bu sayıların ortalamasını ve medyanını
             hesaplayan bir program yazın. Kullanıcı 0 girene kadar sayıları almaya devam etsin. 0
             girildiğinde ortalamayı ve medyanı gösterin.*/


            List<int> sayilar = new List<int>(); // Sayıları tutmak için bir liste oluşturuyoruz
            int sayi;

            // Kullanıcıdan pozitif tam sayılar alma işlemi
            do
            {
                Console.WriteLine("Bir pozitif tam sayı giriniz (bitirmek için 0 giriniz): ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi > 0)
                {
                    sayilar.Add(sayi); // Sadece pozitif tam sayıları listeye ekliyoruz
                }

            } while (sayi != 0); // 0 girildiğinde döngü sona erecek

            // Sayı girdisi olup olmadığını kontrol edelim
            if (sayilar.Count > 0)
            {
                // Ortalamayı hesaplama
                double ortalama = sayilar.Average();
                Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);

                // Medyanı hesaplama
                sayilar.Sort(); // Medyanı hesaplamak için sayıları sıralıyoruz
                double medyan;
                int ortancaIndex = sayilar.Count / 2;

                if (sayilar.Count % 2 == 0)
                {
                    // Çift sayıda eleman varsa ortadaki iki sayının ortalamasını alıyoruz
                    medyan = (sayilar[ortancaIndex - 1] + sayilar[ortancaIndex]) / 2.0;
                }
                else
                {
                    // Tek sayıda eleman varsa ortadaki sayı medyandır
                    medyan = sayilar[ortancaIndex];
                }

                Console.WriteLine("Girilen sayıların medyanı: " + medyan);
            }
            else
            {
                Console.WriteLine("Hiç sayı girilmedi.");
            }

            Console.ReadLine(); // Programın kapanmasını önlemek için bekletiyoruz





            /* Soru 3.) Kullanıcıdan bir dizi tamsayı alın ve bu dizideki ardışık sayı gruplarını tespit eden bir
             program yazın. Örneğin, 1, 2, 3, 5, 6, 7, 10 dizisi için program, 1-3 ve 5-7 gruplarını
             döndürmelidir. Kullanıcı 0 girene kadar sayıları almaya devam etsin.*/

            List<int> sayilar1= new List<int>(); // Sayıları tutmak için bir liste oluşturuyoruz
            int sayi1;

            // Kullanıcıdan pozitif tam sayılar alma işlemi
            do
            {
                Console.WriteLine("Bir tam sayı giriniz (bitirmek için 0 giriniz): ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi != 0)
                {
                    sayilar.Add(sayi); // 0 dışındaki tüm sayıları listeye ekliyoruz
                }

            } while (sayi != 0); // 0 girildiğinde döngü sona erecek

            // Sayı girdisi olup olmadığını kontrol edelim
            if (sayilar.Count > 0)
            {
                sayilar.Sort(); // Sayıları sıralıyoruz

                Console.WriteLine("Ardışık sayı grupları:");

                // Ardışık sayıları gruplamak için bir döngü
                int baslangic = sayilar[0]; // İlk grup başlangıç sayısı
                int onceki = sayilar[0]; // Önceki sayı

                for (int i = 1; i < sayilar.Count; i++)
                {
                    // Eğer ardışık değilse, önceki grubu yazdır ve yeni bir grup başlat
                    if (sayilar[i] != onceki + 1)
                    {
                        if (baslangic == onceki)
                        {
                            Console.WriteLine(baslangic); // Tek bir sayı ise sadece onu yazdır
                        }
                        else
                        {
                            Console.WriteLine(baslangic + "-" + onceki); // Grup şeklinde yazdır
                        }

                        // Yeni grubun başlangıcı
                        baslangic = sayilar[i];
                    }

                    // Önceki sayıyı güncelle
                    onceki = sayilar[i];
                }

                // Son grubu yazdır
                if (baslangic == onceki)
                {
                    Console.WriteLine(baslangic); // Tek bir sayı ise sadece onu yazdır
                }
                else
                {
                    Console.WriteLine(baslangic + "-" + onceki); // Grup şeklinde yazdır
                }
            }
            else
            {
                Console.WriteLine("Hiç sayı girilmedi.");
            }

            Console.ReadLine(); // Programın kapanmasını önlemek için bekletiyoruz





        }
    }
}