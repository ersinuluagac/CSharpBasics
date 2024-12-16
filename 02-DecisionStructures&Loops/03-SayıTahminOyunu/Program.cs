namespace _03_SayıTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 2: Sayı Tahmin Oyunu
            /*
                 1 ile 100 arasında rastgele bir sayı belirleyin. Kullanıcıdan bu sayıyı tahmin etmesini isteyin. Kullanıcı doğru tahmini bulana kadar tahmin yapmasına izin verin. Her tahminde, tahmin edilen sayının büyük veya küçük olduğunu belirtin.
            */

            // Konsol tasarımı
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new string('-', 5) + new string('|', 5) + "Sayı Tahmin Etme Oyunu" + new string('|', 5) + new string('-', 5));
            Console.ResetColor();

            bool start = true;

            // Döngü başlangıcı
            while (start)
            {
                // Konsol tasarımı
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bu oyunumuzda bilgisayarın 1 ile 100 arasında rastgele yarattığı sayıyı tahmin etmeye çalışıyoruz.");
                Console.WriteLine("Sonsuz deneme hakkınız mevcut, hatta size yardımcı da olacağız. Bol şanslar!");
                Console.ResetColor();
                // Rastgele bir sayı yarat
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 101), number;
                Console.WriteLine("Rastgele sayı:");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(randomNumber);
                Console.ResetColor();
                //while (randomNumber > 0 && randomNumber < 101) 
                while (true)
                {
                    // Kullanıcıdan sayı alınır
                    Console.Write("Bir sayı girin... ");
                    bool returnNumber = int.TryParse(Console.ReadLine(), out number);
                    // Sayı kontrolü
                    if (returnNumber == true)
                    {
                        // Sayının doğruluğu veya yakınlığı
                        if (number < randomNumber)
                        {
                            Console.WriteLine("Daha büyük bir sayı deneyin.");
                        }
                        else if (number > randomNumber)
                        {
                            Console.WriteLine("Daha küçük bir sayı deneyin.");
                        }
                        else
                        {
                            Console.WriteLine("Tebrikler");
                            //randomNumber = 0;
                            break;
                            Console.Write("Tekrar oynamak için bir tuşa basın, çıkmak için 'q'ya basmanız yeterli. ");
                            start = Console.ReadLine().ToLower() == "q" ? false : true;
                        }
                    }
                    else
                    {
                        // Konsol tasarımı
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Lütfen sayıları rakamlar ile girin!");
                        Console.Beep();
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
