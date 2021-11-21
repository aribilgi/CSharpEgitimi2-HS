using System;

namespace Ders06Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Döngüsü");
            int toplam = 0;
            for (int i = 0; i < 5; i++)//i değişkeni oluştur ve 0 değerini ata; i 10 dan küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
            {
                toplam += i;
                Console.WriteLine("i değişkeninin değeri {0} toplamın değeri {1}", i, toplam);
            }

            Console.WriteLine("While Döngüsü");
            int w = 0;
            while (w < 5) //While döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön
            {
                Console.WriteLine("While Sayı {0}", w);//toplamın değerini ekrana yazdırıyoruz
                w++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }

            Console.WriteLine("Do While Döngüsü");
            int toplam2 = 0;
            do
            {
                Console.WriteLine("Do while Sayı {0}", toplam2);//toplamın değerini ekrana yazdırıyoruz
                toplam2++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }
            while (toplam2 < 5); //Do While döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön



            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" };

            Console.WriteLine("Foreach Döngüsü");
            foreach (var item in kategoriler)
            {
                Console.WriteLine("Kategori Adı : " + item);
            }


        }
    }
}
