using System;
using System.Collections.Generic;


namespace UML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci ve Okul
            Okul okul1 = new Okul { Ad = "Anadolu Lisesi", Adres = "İstanbul" };
            Ogrenci ogrenci1 = new Ogrenci { Ad = "Ali", Yas = 16, Okul = okul1 };
            Console.WriteLine($"{ogrenci1.Ad}, {ogrenci1.Okul.Ad}'a kayıtlıdır.");

            // Yazar ve Kitap
            Yazar yazar = new Yazar { Ad = "Orhan Pamuk", Ulke = "Türkiye" };
            Kitap kitap = new Kitap { Baslik = "Masumiyet Müzesi", ISBN = "123456789" };
            yazar.Kitaplar.Add(kitap);
            Console.WriteLine($"{yazar.Ad} tarafından yazılan kitap: {kitap.Baslik}");

            // Çalışan ve Departman
            Departman departman = new Departman { Ad = "Bilgi İşlem", Lokasyon = "Kat 2" };
            Calisan calisan = new Calisan { Ad = "Mehmet", Pozisyon = "Yazılım Uzmanı", Departman = departman };
            Console.WriteLine($"{calisan.Ad}, {calisan.Departman.Ad} departmanında çalışmaktadır.");

            // Ürün ve Sipariş
            Urun urun = new Urun { Ad = "Bilgisayar", Fiyat = 15000 };
            Siparis siparis = new Siparis { Tarih = DateTime.Now, Toplam = 15000 };
            Console.WriteLine($"Sipariş: {urun.Ad}, Toplam: {siparis.Toplam} TL");

            // Müşteri ve Sipariş
            Musteri musteri = new Musteri { Ad = "Ayşe", Telefon = "0555 123 4567" };
            Siparis siparis2 = new Siparis { Tarih = DateTime.Now, Durum = "Tamamlandı" };
            Console.WriteLine($"Müşteri: {musteri.Ad}, Sipariş Durumu: {siparis2.Durum}");

            // Araba ve Tekerlek
            Araba araba = new Araba { Model = "BMW" };
            Tekerlek tekerlek = new Tekerlek { Ad = "Michelin", Tip = "Kışlık" };
            araba.Tekerlekler.Add(tekerlek);
            Console.WriteLine($"Araba: {araba.Model}, Tekerlek: {tekerlek.Ad}");

            // Otomobil ve Motor
            Motor motor = new Motor { Guç = 150, Tip = "Dizel" };
            Otomobil otomobil = new Otomobil { Marka = "Toyota", Motor = motor };
            Console.WriteLine($"Otomobil: {otomobil.Marka}, Motor Gücü: {otomobil.Motor.Guç} HP, Tipi: {otomobil.Motor.Tip}");

            // Okul ve Öğrenci (Yeni)
            Okul okul2 = new Okul { Ad = "Fırat Üniversitesi" };
            Ogrenci ogrenci2 = new Ogrenci { Ad = "Ahmet", Yas = 22 };
            okul2.Ogrenciler.Add(ogrenci2);
            Console.WriteLine($"Okul: {okul2.Ad}, Öğrenci: {ogrenci2.Ad}, Yaş: {ogrenci2.Yas}");
            Console.ReadLine();
        }
    }

    // Daha Önceki Sınıf Tanımları
    class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Okul Okul { get; set; }
    }

    class Okul
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }

    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();
    }

    class Kitap
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Departman Departman { get; set; }
    }

    class Departman
    {
        public string Ad { get; set; }
        public string Lokasyon { get; set; }
    }

    class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    class Siparis
    {
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }
        public string Durum { get; set; }
    }

    class Musteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
    }

    class Araba
    {
        public string Model { get; set; }
        public List<Tekerlek> Tekerlekler { get; set; } = new List<Tekerlek>();
    }

    class Tekerlek
    {
        public string Ad { get; set; }
        public string Tip { get; set; }
    }

    // Yeni Sınıflar
    class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }
    }

    class Motor
    {
        public int Guç { get; set; }
        public string Tip { get; set; }
    }
}
