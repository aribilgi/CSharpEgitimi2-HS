using System;

namespace Ders01Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Heap, Stack
            //C# ta 2 tipte yapı vardır 
            //1-Değer Tipleri (Stack te tutulur)
            //2-Referans Tipleri (Belleğin heap bölgesinde tutulur, sınıflara ait tüm nesneler burada tutulur)

            //Tam sayı veri tipi
            byte plaka_kodu = 81;
            int tamSayi = 214748364;

            //Kesirli sayı değişken tipleri
            float kesirliSayi1 = 34.18f; //float veri tipinde sayının sonuna f harfi eklenir. 4 byte yer kaplar, 6-7 basamak sayı alabilir
            double kesirliSayi2 = 34.18; //8 byte yer kaplar, 15-16 basamak sayı alabilir

            //Decimal veri tipi
            decimal urunFiyati = 9999; //12 byte 28-29 basamağa kadar destekler

            //Char veri tipi
            char karakter = 'k'; // Sadece 1 karakter veri alabilir

            //String veri tipi
            string metin = "string veri tipinde klavyedeki tüm karakterleri kullanabiliriz";

            //Boolean veri türü
            bool urunDurumu = true; //bool 2 değer alır true veya false, 1 byte lık yer kaplar

            //C# ta sabit tanımlama
            const int kdv = 18; // veri tipinden önce const ifadesini yazarak sabit değerler tanımlayabilriz
            const int iskonto = 20; //sabitlerin başlangıç esnasında değer ataması yapılır

            Console.WriteLine(metin);
        }
    }
}
