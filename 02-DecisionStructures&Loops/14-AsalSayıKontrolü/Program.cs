namespace _14_AsalSayıKontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 13: Asal Sayı Kontrolü
            /*
                Kullanıcıdan bir sayı alın ve bu sayının asal olup olmadığını kontrol eden bir program yazın. 
                * Asal sayı: Sadece 1 ve kendisi ile bölünebilen sayılar, örneğin 2, 3, 5, 7
            */

            Console.WriteLine("Asal Sayı Kontrolüne Hoş Geldiniz");

            int sayi;
            bool basla = true, asalKontrol = true;


            while (basla)
            {
                Console.Write("Lütfen bir sayı girin: ");
                bool donusSayi = int.TryParse(Console.ReadLine(), out sayi);
                if (donusSayi)
                {
                    if (sayi <= 1)
                    {
                        Console.WriteLine("Bir ve daha küçük sayılar asal değildir.");
                    }
                    else if (sayi == 2)
                    {
                        Console.WriteLine("İki en küçük asal sayıdır.");
                    }
                    else if (sayi % 2 == 0)
                    {
                        Console.WriteLine("İkiden büyük çift sayılar asal değildir.");
                    }
                    else
                    {
                        bool asal = true;
                        int i = 3;
                        while (i * i <= sayi)
                        {
                            if (sayi % i == 0)
                            {
                                asal = false;
                                break;
                            }
                            i += 2;
                        }
                        if (asal)
                        {
                            Console.WriteLine($"Girdiğiniz {sayi} sayısı asaldır!");
                        }
                        else
                        {
                            Console.WriteLine($"Girdiğiniz {sayi} sayısı asal değildir.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayıları rakamlarla girin!");
                }
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Başka bir sayı kontrol etmek için bir tuşa basın, çıkmak için 'çıkış' yazın.");
                Console.ResetColor();
                basla = Console.ReadLine().ToLower() == "çıkış" ? false : true;

            }
        }
    }
}
