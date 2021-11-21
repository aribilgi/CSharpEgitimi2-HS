using System;

namespace Ders17AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes!");
            Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();//Database sınıfından yeni bir SqlServer nesnesi oluşturuyoruz
            database2.Add();
            database2.Delete();

        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add metodu çalıştı Ekleme yapıldı");
        }

        public abstract void Delete();//crud
        public abstract void Update();//crud
        public abstract void Get();//crud
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt SqlServer dan silindi");
        }

        public override void Get()
        {
            Console.WriteLine("Kayıt SqlServer dan getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("Kayıt SqlServer da güncellendi");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle den silindi");
        }

        public override void Get()
        {
            Console.WriteLine("Oracle den kayıt getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle deki kayıt güncellendi");
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("MySql dan silindi");
        }

        public override void Get()
        {
            Console.WriteLine("MySql den kayıt getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("MySql deki kayıt güncellendi");
        }
    }
}
