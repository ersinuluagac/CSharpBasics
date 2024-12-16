namespace _06_ÇarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 5: Çarpım Tablosu 
            /*
                Kullanıcıdan bir sayı alın ve bu sayının çarpım tablosunu (1 ile 10 arasında) ekrana yazdırın.
            */
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('*', 12) + "Çarpım Tablosuna Hoş Geldiniz" + new string('*', 12));
            Console.ResetColor();
            bool basla = true;
            int sayi;

            while (basla)
            {
                Console.Write("Lütfen çarpım tablosunu görmek istediğiniz sayıyı girin: ");
                bool donus = int.TryParse(Console.ReadLine(), out sayi);
                if (donus)
                {
                    Console.WriteLine("Girdiğiniz sayının 1 ile 10 arasındaki sayılarla çarpımı:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{sayi} * {i} = {sayi * i}");
                    }
                    Console.WriteLine("Yeni bir sayı girmek için bir tuşa basın, çıkmak için 'çıkış' yazmanız yeterli.");
                    basla = Console.ReadLine().ToLower() == "çıkış" ? false : true;
                }
                else
                {
                    Console.WriteLine("Bir hata oluştu! Lütfen sayıyı rakamlarla giriniz.");
                }
            }
        }
    }
}
