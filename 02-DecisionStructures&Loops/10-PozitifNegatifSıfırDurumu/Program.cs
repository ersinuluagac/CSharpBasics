namespace _10_PozitifNegatifSıfırDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 9: Girilen Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme
            /*
                Kullanıcıdan bir sayı alın ve bu sayının pozitif, negatif veya sıfır olduğunu belirleyerek ekrana yazdıran bir program yazın.
            */

            Console.WriteLine("Sayının Pozitif, Negatif veya Sıfır Olma Durumunu Belirleme");

            double sayi;
            bool basla = true;

            while (basla)
            {
                Console.Write("Lütfen bir sayı girin: ");
                double.TryParse(Console.ReadLine(), out sayi);
                if (sayi > 0)
                {
                    Console.WriteLine("Girdiğiniz sayı pozitif!");
                }
                else if (sayi < 0)
                {
                    Console.WriteLine("Girdiğiniz sayı negatif");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı sıfır");
                }
                Console.WriteLine("Yeni bir sayı girmek için bir tuşa basın, çıkmak için 'çıkış' yazın.");
                basla = Console.ReadLine() == "çıkış" ? false : true;
            }
        }
    }
}
