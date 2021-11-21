using System;
using Ders08SiniflarClasses;

namespace Ders09ErisimBelirleyiciler
{
    /*C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.Sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
     * Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri"(acces modifiers) denir.
     * 
     * Erişim belirtecleri 4 ana sınıfa ayrılır
     * public:Erişim kısıtı yoktur,her yerden erişilebilir.
     * protected:Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
     * internal:Etkin projeye ait sınıflardan erişilebilir,onların dışında erişilemez
     * private:Yalnız bulunduğu sınıftan erişilebilir,dıştaki sınıflardan erişilemez
     * Bir öğe yalnızca 1 erişim belirteci alabilir
     * namespace erişim belirteci almaz çünkü o daima publictir,
     * Sınıflar public ya da internal nitelemesi alabilirler ama protected ya da private nitelemesi alamazlar
     * enum erişim belirteci almaz çünkü daima publicir
     * */
    public class deneme
    {
        public string urunAdi = "public öğeye herkes erişebilir";
    }
    internal class test
    {
        string urunAdi;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Admin";
            kullanici.Soyadi = "User";            

            Console.WriteLine($"Kullanıcı bilgileriniz; Kullanıcı Adı : {kullanici.Adi}, Soyadı : {kullanici.Soyadi}");

            SiniftaMetotKullanimi siniftaMetotKullanimi = new SiniftaMetotKullanimi();
            siniftaMetotKullanimi.ToplamaYap();

            Console.Read();
        }
    }
}
