using System;
using System.Collections.Generic;

namespace OtomasyonSistemi
{
    // Soru 1: Banka Hesabı Sınıfı
    public class BankaHesabi
    {
        public string HesapNumarasi { get; private set; }
        private decimal bakiye;

        public decimal Bakiye
        {
            get { return bakiye; }
            private set { bakiye = value; }
        }

        public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
        {
            HesapNumarasi = hesapNumarasi;
            Bakiye = ilkBakiye;
        }

        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
            }
        }

        public void ParaCek(decimal miktar)
        {
            if (miktar > 0 && miktar <= Bakiye)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
    }

    // Soru 2: Ürün Sınıfı
    public class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        private decimal indirim;

        public decimal Indirim
        {
            get { return indirim; }
            set
            {
                if (value >= 0 && value <= 50)
                    indirim = value;
                else
                    Console.WriteLine("İndirim 0 ile 50 arasında olmalı.");
            }
        }

        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public decimal IndirimliFiyat()
        {
            return Fiyat * (1 - Indirim / 100);
        }
    }

    // Soru 3: Araç Kiralama Sınıfı
    public class KiralikArac
    {
        public string Plaka { get; set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitMi { get; private set; } = true;

        public KiralikArac(string plaka, decimal gunlukUcret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukUcret;
        }

        public void AraciKirala()
        {
            if (MusaitMi)
            {
                MusaitMi = false;
                Console.WriteLine($"{Plaka} plakalı araç kiralandı.");
            }
            else
            {
                Console.WriteLine($"{Plaka} plakalı araç zaten kirada.");
            }
        }

        public void AraciTeslimEt()
        {
            if (!MusaitMi)
            {
                MusaitMi = true;
                Console.WriteLine($"{Plaka} plakalı araç teslim edildi.");
            }
            else
            {
                Console.WriteLine($"{Plaka} plakalı araç zaten müsait.");
            }
        }
    }

    // Soru 4: Adres Defteri Sınıfı
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }

        public Kisi(string ad, string soyad, string telefonNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }

        public string KisiBilgisi()
        {
            return $"Ad: {Ad} {Soyad}, Telefon: {TelefonNumarasi}";
        }
    }

    // Soru 5: Kütüphane Sınıfı
    public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }

        public Kitap(string ad, string yazar)
        {
            Ad = ad;
            Yazar = yazar;
        }

        public override string ToString()
        {
            return $"Kitap: {Ad}, Yazar: {Yazar}";
        }
    }

    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; private set; } = new List<Kitap>();

        public void KitapEkle(Kitap yeniKitap)
        {
            this.Kitaplar.Add(yeniKitap);
            Console.WriteLine($"{yeniKitap.Ad} kütüphaneye eklendi.");
        }

        public void KitaplariListele()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
    }

    // Main Sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            // Soru 1: Banka Hesabı Örneği
            BankaHesabi hesap = new BankaHesabi("123456", 500);
            hesap.ParaYatir(200);
            hesap.ParaCek(100);

            // Soru 2: Ürün Örneği
            Urun urun = new Urun("Telefon", 3000);
            urun.Indirim = 20;
            Console.WriteLine($"{urun.Ad} indirimli fiyatı: {urun.IndirimliFiyat()} TL");

            // Soru 3: Araç Kiralama Örneği
            KiralikArac arac = new KiralikArac("34ABC123", 150);
            arac.AraciKirala();
            arac.AraciTeslimEt();

            // Soru 4: Adres Defteri Örneği
            Kisi kisi = new Kisi("Ahmet", "Yılmaz", "555-1234");
            Console.WriteLine(kisi.KisiBilgisi());

            // Soru 5: Kütüphane Örneği
            Kutuphane kutuphane = new Kutuphane();
            Kitap kitap1 = new Kitap("Suç ve Ceza", "Fyodor Dostoyevski");
            Kitap kitap2 = new Kitap("Sefiller", "Victor Hugo");
            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            kutuphane.KitaplariListele();

            // Konsolu açık tutmak için
            Console.ReadLine();
        }
    }
}
