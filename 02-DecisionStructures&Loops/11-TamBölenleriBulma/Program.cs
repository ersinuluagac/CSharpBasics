namespace _11_TamBölenleriBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 10: Tam Bölenleri Bulma
            /*
                Kullanıcıdan bir sayı alın ve bu sayının tam bölenlerini ekrana yazdıran bir program yazın. 
                * Örneğin, 12 için tam bölenler: 1, 2, 3, 4, 6, 12
            */
            Console.WriteLine($"{new string('^', 15)} Tam Bölenleri Bulma {new string('^', 15)}");

            int sayi;
            string tamBolenler = "";
            bool basla = true;

            while (basla)
            {
                Console.WriteLine("Tam bölenlerini bulmak istediğiniz sayıyı yazın: ");
                bool donusSayi = int.TryParse(Console.ReadLine(), out sayi);
                if (donusSayi)
                {
                    if (sayi > 0)
                    {
                        for (int i = 1; sayi >= i; i++)
                        {
                            if (sayi % i == 0)
                            {
                                tamBolenler += $"{i.ToString()}, ";
                            }
                        }
                    }
                    else if (sayi < 0)
                    {
                        for (int i = -1; sayi <= i; i--)
                        {
                            if (sayi % i == 0)
                            {
                                tamBolenler += $"{i.ToString()}, ";
                                tamBolenler += $"{(-1 * i).ToString()}, ";
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Girdiğiniz sayı {sayi}. {sayi}'ın tüm sayılara bölümü {sayi}'dır.");
                    }
                    Console.WriteLine(tamBolenler);
                    tamBolenler = "";
                    Console.WriteLine("Başka bir sayının tam bölenlerini bulmak için bir tuşa basın, çıkmak için 'çıkış' yazın");
                    basla = Console.ReadLine() == "çıkış" ? false : true;
                }
                else
                {
                    Console.WriteLine("Lütfen sayıları rakamlar ile giriniz!");
                }
            }
        }
    }
}
