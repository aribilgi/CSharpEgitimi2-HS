using System;
using System.Collections.Generic;
using System.Text;

namespace Ders08SiniflarClasses
{
    public class SiniftaMetotKullanimi
    {
        string mesaj = "";
        public SiniftaMetotKullanimi()  //ctor yazıp klavyeden tab tab yaparak oluşturulabilir
        {
            //Burası kurucu metot
            mesaj = "Kurucu metot çalıştı";
            Console.WriteLine(mesaj);
        }
        public void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }
        public static void ToplamaYap(int sayi1, int sayi2)  //STATİK METOT YAPIMI OLMUŞ OLDU BU DA
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        public static string StatikDegisken = "Sınıfta statik değişken kullanımı";
    }
}
