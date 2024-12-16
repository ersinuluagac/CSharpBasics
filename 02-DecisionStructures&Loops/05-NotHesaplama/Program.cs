namespace _05_NotHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 4: Not Hesaplama 
            /*
                Kullanıcıdan üç farklı ders notu alın ve bu notların ortalamasını hesaplayarak ekrana yazdırın. Ortalamaya göre öğrencinin durumunu belirleyin
                * 85 ve üzeri: "Pekiyi"
                * 70-84 arası: "İyi"
                * 50-69 arası: "Orta"
                * 50'nin altı: "Geçersiz"
            */
            double not1, not2, not3, ortalama = 0;
            bool basla = true;

            while (basla)
            {
                Console.Write("Lütfen birinci notunuzu giriniz: ");
                bool donusNot1 = double.TryParse(Console.ReadLine(), out not1);
                Console.Write("Lütfen ikinci notunuzu giriniz: ");
                bool donusNot2 = double.TryParse(Console.ReadLine(), out not2);
                Console.Write("Lütfen üçüncü notunuzu giriniz: ");
                bool donusNot3 = double.TryParse(Console.ReadLine(), out not3);
                if (donusNot1 == true && donusNot2 == true && donusNot3 == true)
                {
                    if (not1 >= 0 && not1 <= 100 && not2 >= 0 && not2 <= 100 && not3 >= 0 && not3 <= 100)
                    {
                        ortalama = (not1 + not2 + not3) / 3;
                        if (ortalama >= 85 && ortalama <= 100)
                        {
                            Console.WriteLine($"Pekiyi! Ortalamanız: {ortalama}");
                        }
                        else if (ortalama >= 70 && ortalama <= 84)
                        {
                            Console.WriteLine($"İyi! Ortalamanız: {ortalama}");
                        }
                        else if (ortalama >= 50 && ortalama <= 69)
                        {
                            Console.WriteLine($"Orta! Ortalamanız: {ortalama}");
                        }
                        else
                        {
                            Console.WriteLine($"Geçersiz! Ortalamanız: {ortalama}");
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                        Console.WriteLine("Girilen notlar 0 ile 100 arasında olmalıdır!");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                    Console.WriteLine("Lütfen notları rakamlar ile giriniz!");
                    Console.ResetColor();
                }
                Console.Write("Tekrar hesaplama için bir tuşa basın, çıkmak için 'çıkış' yazın: ");
                basla = Console.ReadLine().ToLower() == "çıkış" ? false : true;
            }
        }
    }
}
