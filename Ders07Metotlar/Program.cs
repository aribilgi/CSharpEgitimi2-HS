using System;

namespace Ders07Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metotlar");
            ToplamaYap();
            ToplamaYap(28, 8);
            var sonuc = MailGonder("info@bilgi.co");
            if (sonuc == true)
            {
                Console.WriteLine("Mail Gönderildi!");
            }
            else Console.WriteLine("Mail Gönderilemedi!");
        }


        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }

        static void ToplamaYap(int sayi1, int sayi2)//metotların parametre ile kullanımı
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        static bool MailGonder(string mailAdresi)
        {
            string sistemdekiMailAdresi = "info@bilgi.co";
            if (mailAdresi == sistemdekiMailAdresi)
            {
                //Burada mail gönderim kodları olacak
                return true;
            }
            else return false;
        }

    }
}
