using System;

namespace Ders16InterfacesArayuzler
{
    interface OrnekArayuz //Örnek arayüz oluşturma
    {
        int Id { get; set; }
    }
    interface Idemo
    {
        //Arayüz tanımlaması interface ifadesi ile yapılır ve yapacağı işleme göre I harfiyle başlayan bir isim verilir
        void Goster();//Interface lerde sadece metot imzaları yer alır, metotlar bu interface den miras alan class larda kullanılır
    }
    interface icerebilecekleri : Idemo
    {
        //Bir interface in içerebileceği özellikler
        //public int sayi1 { get; set; } //bir interface içerisine prop tab tab ile property eklersek başındaki public ifadesini kaldırmak zorundayız çünkü interfaceler erişim belirteci almaz daima public tir zaten
        int sayi { get; set; }        
        void Goster2();//interface ler metot imzalarını barındırabilir
        int ToplamaYap();//metot imzalarında da public vb erişim belirteci kullanılmaz
        //İçeremedikleri
        //static int sayi { get; set; } //interfacelerde bu şekilde static kullanılamaz
        //string metin; //interfaceler içerisinde değişken kullanılamaz
        //interfaceler class lardaki kurucu metotları da kullanamaz
        /*int CikarmaYap()
        {
            int sayi1 = 5; int sayi2 = 10; //interfacelerde metotların yapacağı iş bu şekilde tanımlanamaz, hata verir, metotların sadece adı tanımlanır ne iş yapacağı kullanılacağı yere bırakılır
            return sayi2 - sayi1;
        }*/
    }
    class arayuzKullanimi : icerebilecekleri
    {
        public int sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine("arayuzKullanimi sınıfı içerisindeki goster metodu çalıştı");
        }

        public void Goster2()
        {
            Console.WriteLine("Goster2");
        }

        public int ToplamaYap()
        {
            return 10 + 8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces Arayüzler!");

            arayuzKullanimi arayuz = new arayuzKullanimi();
            arayuz.sayi = 18;
            arayuz.Goster();

            Urun urun = new Urun()
            {
                CreateDate = DateTime.Now,
                ChangeDate = DateTime.Now,
                Name = "Cep Telefonu",
                Price = 9999
            };
            urun.Add();
        }
    }
    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ChangeDate { get; set; }
        string User { get; set; }
    }
    interface VeritabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
    class Kategori : ISinifGereksinimleri, VeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }
        public void Add()
        {
            Console.WriteLine("Kategori eklendi");
        }
        public void Delete()
        {
            Console.WriteLine("Kategori silindi");
        }
        public void Get()
        {
            Console.WriteLine("Kategori getirildi");
        }
        public void GetAll()
        {
            Console.WriteLine("Kategoriler getirildi");
        }
        public void Update()
        {
            Console.WriteLine("Kategori güncellendi");
        }
    }
    class Urun : ISinifGereksinimleri, VeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public void Add()
        {
            Console.WriteLine("Ürün eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Ürün silindi");
        }

        public void Get()
        {
            Console.WriteLine("Ürün getirildi");
        }

        public void GetAll()
        {
            Console.WriteLine("Ürünler getirildi");
        }

        public void Update()
        {
            Console.WriteLine("Ürün güncellendi");
        }
    }
    class Marka : ISinifGereksinimleri, VeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }
        public string Logo { get; set; }
        public void Add()
        {
            Console.WriteLine("Marka eklendi");
        }
        public void Delete()
        {
            Console.WriteLine("Marka silindi");
        }
        public void Get()
        {
            Console.WriteLine("Marka getirildi");
        }
        public void GetAll()
        {
            Console.WriteLine("Markalar getirildi");
        }
        public void Update()
        {
            Console.WriteLine("Marka güncellendi");
        }
    }
}
