using System;

namespace Ders08SiniflarClasses       //sınıflar soyut veri tipleridir.
{
    class Ev  //C# ta kendi sınıflarımızı bu şekilde oluşturabiliriz. Bir sınıfın içinde birden fazla veri tipi olabilir.//Hem int hem string oluşturduk aşağıda.
    {
        public int KapiNo;      //public=erişim belirteci
        public string SokakAdi;
    }
    class Program    //Sınıfların içinde değişken,veri tipi tanımlanabildiği gibi metot da tanımlanabilir.
    {
        static void Main(string[] args)
        {
            Ev evAdresi = new Ev(); //SINIFTAN NESNE OLUŞTURMA
            evAdresi.KapiNo = 18;  //Sınıftan oluşan nesnelere değer atama işlemi
            evAdresi.SokakAdi = "Arı Sokak";  //Sınıftan oluşan nesnelere değer atama işlemi

            //Console.WriteLine("Aylinin adresi:{0} No:{1} İstanbul", evAdresi.SokakAdi, evAdresi.KapiNo);//Sınıftan oluşan nesnelerin değerini okuma işlemi

            Ev yazlik = new Ev()
            {
                SokakAdi = "Yalıkavak sokak",
                KapiNo = 1
            };
            //Console.WriteLine($"Aylinin yazlık adresi:{yazlik.SokakAdi} No:{yazlik.KapiNo} Bodrum");  //Dolar işareti koyarsak (sonradan eklendi bu özellik) stringin başına dolar koyarsak süslü parantezlerle parametreyi kullanabiliriz.

            // Console.Read();

            Console.WriteLine();
            Kurs kurs = new Kurs()
            {
                EgitimAdi = "Yazılım Uzmanlığı",
                KapiNo = 102,
                Gunleri = "Hafta içi",
                KursAdi = "Arı Bilgi",
                SinifMevcut = 4
            };
            //Console.WriteLine($"Kurs Bilgileri:\n Egitim Adı: { kurs.EgitimAdi}");
            //Console.WriteLine($"Kurs Adı:{kurs.KursAdi}");
            //Console.WriteLine($"Kapı No: { kurs.KapiNo}");
            //Console.WriteLine($"Kurs Günleri: { kurs.Gunleri}");
            //Console.WriteLine($"Sınıf Mevcudu: { kurs.SinifMevcut}");

            SiniftaMetotKullanimi siniftaMetotKullanimi = new SiniftaMetotKullanimi();
            siniftaMetotKullanimi.ToplamaYap();

            Console.WriteLine(SiniftaMetotKullanimi.StatikDegisken); //Sınıflarda static bir değişken veya metot kullanırsak sınıftan new ile örnek almadan direk SınıfAdı.Değişken-MetotAdi şeklinde kullanabiliriz.
            SiniftaMetotKullanimi.ToplamaYap(18, 18);
            Console.Read();
        }
    }

    class Kurs
    {
        public int KapiNo;
        public string KursAdi;
        public string EgitimAdi;
        public int SinifMevcut;
        public string Gunleri;
    }
}
