using System;

namespace Ders05KosulYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = -10;

            if (sayi > 0)//eğer sayı 0 dan büyükse
            {
                // burası işletilir.
                Console.WriteLine("sayı pozitif");
            }
            else if (sayi == 0)//yukardaki değilse eğer sayı 0 a eşitse
            {
                // burası işletilir
                Console.WriteLine("sayı sıfırdır");
            }
            else//yukardakilerin hiçbiri değilse
            {
                //sayı 0 dan küçükse işletilir.
                Console.WriteLine("sayı negatif");
            }

            Console.WriteLine("1 ile 12 arasında bir sayı giriniz :");
            /**/

            int ay = DateTime.Now.Month;//Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;
                default:
                    Console.WriteLine("Yanlış bilgi.");
                    break;
            }

        }
    }
}
