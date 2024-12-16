namespace _04_TekÇiftSayıKontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 3: Tek-Çift Sayı Kontrolü 
            /*
                 Kullanıcıdan bir sayı alın ve bu sayının tek mi yoksa çift mi olduğunu ekrana yazdıran bir program yazın. Programın bir döngü içerisinde çalışmasını ve kullanıcı "çıkış" yazana kadar tekrar tekrar sayı almasını sağlayın.
            */
            int number;
            bool basla = true;

            while (basla)
            {
                Console.Write("Tek-Çift kontrolü yapılacak sayıyı giriniz: ");
                bool returnNumber = int.TryParse(Console.ReadLine(), out number);
                if (returnNumber == true)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Girdiğiniz sayı çift. Sayı: {number}");
                    }
                    else
                    {
                        Console.WriteLine($"Girdiğiniz sayı tek. Sayı: {number}");
                    }
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Uygulamadan çıkmak ister misiniz? Küçük harflerle 'çıkış' yazmanız yeterli. Devam etmek için bi tuşa basın.");
                    Console.ResetColor();
                    basla = Console.ReadLine() == "çıkış" ? false : true;
                }
                else
                {
                    Console.WriteLine("Lütfen sayıyı rakamlar ile giriniz!");
                    Console.Beep();
                }
            }
        }
    }
}
