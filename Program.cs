using System;

namespace MiniATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 1000;
            Console.WriteLine("ATM'ye Hoşgeldiniz");
            Console.WriteLine("İşlemler:\n1- Bakiye Görüntüleme\n2- Para Çekme\n3- Para Yatırma\nq- Çıkış Yap");
            Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Mevcut bakiyeniz: " + balance);
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                int money = Convert.ToInt32(Console.ReadLine());

                if (money <= balance)
                {
                    Console.WriteLine("Kalan bakiyeniz: " + (balance - money));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz!");
                    Console.ReadLine();
                }
            }
            else if (choice == "3")
            {
                Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz: " + (balance + price));
                Console.ReadLine();
            }
            else if (choice == "q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor...");
                Console.WriteLine("Çıkış yapıldı, iyi günler.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                Console.ReadLine();
            }
        }
    }
}
