namespace _09_FaktöriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 8: Faktöriyel Hesaplama
            /*
                Kullanıcıdan bir sayı alın ve bu sayının faktöriyelini hesaplayıp ekrana yazdıran bir program yazın. 
                * Örneğin, 5! = 5 x 4 x 3 x 2 x 1 = 120
            */

            Console.WriteLine(new string('+', 15) + " Faktöriyel Hesaplama " + new string('+', 15));

            uint sayi;
            ulong faktoriyel;
            bool basla = true;

            while (basla)
            {
                faktoriyel = 1;
                Console.Write("Faktöriyelinin hesaplanmasını istediğiniz sayıyı giriniz: ");
                bool donusSayi = uint.TryParse(Console.ReadLine(), out sayi);
                if (donusSayi)
                {
                    if (sayi > 0)
                    {
                        for (uint i = 1; i <= sayi; i++)
                        {
                            faktoriyel *= i;
                        }
                        Console.WriteLine(faktoriyel);
                    }
                    else if (sayi == 0)
                    {
                        Console.WriteLine("0 sayısının faktöriyel sonucu 1'dir.");
                    }
                    else
                    {
                        Console.WriteLine("Negatif ve kesirli sayıların faktöriyeli olmaz!");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayıyı rakamlarla giriniz!");
                }
                Console.WriteLine("Yeni bir hesapalama yapmak isterseniz bir tuşa basın, çıkmak için 'çıkış' yazmanız yeterli. ");
                basla = Console.ReadLine() == "çıkış" ? false : true;
            }
        }
    }
}
