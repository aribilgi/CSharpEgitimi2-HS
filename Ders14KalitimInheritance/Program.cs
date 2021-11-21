using System;

namespace Ders14KalitimInheritance
{
    class Arac //Base class
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Biiiiip");
        }
    }
    class Otomobil : Arac //Child class
    {
        public string marka = "Tofaş";
        public string modeli = "Serçe";
    }
    public class AtaSinif//Miras alınacak olan baba sınıf
    {
        public AtaSinif()//Kurucu method, kurucu metotlar classlar ile aynı isimde olur ve class new lenerek bir yerde kullanılmak istenirse ilk çalışan metot kurucu metottur, sonra class içindeki diğer metotlar çalışır
        {
            Console.WriteLine("Ata sınıf kurucu metot çalıştı");
        }
        public void Yaz()
        {
            Console.WriteLine("Ata sınıftaki yaz metodu çalıştı");
        }
    }
    public class OgulSinif : AtaSinif//Burada OgulSinif AtaSinif dan miras alarak onun özelliklerine sahip oluyor
    {
        public OgulSinif()
        {
            Console.WriteLine("oğul kurucu metot çalıştı");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım Inheritance!");
            Otomobil otomobil = new Otomobil();
            otomobil.KornaCal();
            otomobil.AracTuru = "Otomobil";
            Console.WriteLine(otomobil.AracTuru);
            Console.WriteLine(otomobil.marka);
            Console.WriteLine(otomobil.modeli);

            OgulSinif ogul = new OgulSinif();//OgulSinif dan bir nesne türetiyoruz
            ogul.Yaz();

            Cizici[] birCizici = new Cizici[4];

            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (Cizici sayac in birCizici)
            {
                sayac.Ciz();
            }

        }
    }
    //Polimorfizm (Çok biçimlilik) : Bir fonksiyonun normal davranışının ezilerek farklı bir çıktı elde etmesini sağladığımız yöntem
    public class Cizici
    {
        public virtual void Ciz() //virtual ibaresi ile ciz metodumuzu ezilebilir hale getirdik
        {
            Console.WriteLine("Çizici");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz() //override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Düz çizgi");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Kare");
        }
    }

}
