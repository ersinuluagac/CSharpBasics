namespace _13_BüyükKüçükSayıyıBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 12: En Büyük ve En Küçük Sayıyı Bulma
            /*
                Kullanıcıdan 5 sayı alın ve bu sayılar arasından en büyük ve en küçük olanı ekrana yazdıran bir program yazın.
            */

            Console.WriteLine("Hoş Geldiniz.");
            Console.WriteLine("Girdiğiniz beş sayının en küçüğünü ve en büyüğünü bulacağım.");

            int sayi1, sayi2, sayi3, sayi4, sayi5, kucukSayi, buyukSayi;
            bool basla = true;

            while (basla)
            {
                Console.Write("Lütfen ilk sayıyı giriniz: ");
                bool don1 = int.TryParse(Console.ReadLine(), out sayi1);
                Console.Write("Lütfen ikinci sayıyı giriniz: ");
                bool don2 = int.TryParse(Console.ReadLine(), out sayi2);
                Console.Write("Lütfen üçüncü sayıyı giriniz: ");
                bool don3 = int.TryParse(Console.ReadLine(), out sayi3);
                Console.Write("Lütfen dördüncü sayıyı giriniz: ");
                bool don4 = int.TryParse(Console.ReadLine(), out sayi4);
                Console.Write("Lütfen beşinci sayıyı giriniz: ");
                bool don5 = int.TryParse(Console.ReadLine(), out sayi5);

                if (don1 == true && don2 == true && don3 == true && don4 == true && don5 == true)
                {
                    kucukSayi = (sayi1 < sayi2) && (sayi1 < sayi3) && (sayi1 < sayi4) && (sayi1 < sayi5) ? sayi1 :
                                kucukSayi = (sayi2 < sayi3) && (sayi2 < sayi4) && (sayi2 < sayi5) ? sayi2 :
                                kucukSayi = (sayi3 < sayi4) && (sayi3 < sayi5) ? sayi3 :
                                kucukSayi = (sayi4 < sayi5) ? sayi4 : sayi5;
                    buyukSayi = (sayi1 > sayi2) && (sayi1 > sayi3) && (sayi1 > sayi4) && (sayi1 > sayi5) ? sayi1 :
                                buyukSayi = (sayi2 > sayi3) && (sayi2 > sayi4) && (sayi2 > sayi5) ? sayi2 :
                                buyukSayi = (sayi3 > sayi4) && (sayi3 > sayi5) ? sayi3 :
                                buyukSayi = (sayi4 > sayi5) ? sayi4 : sayi5;

                    Console.WriteLine($"Girilen Sayılar: {sayi1}, {sayi2}, {sayi3}, {sayi4}, {sayi5}");
                    Console.WriteLine($"Küçük Sayı: {kucukSayi} | Büyük Sayı: {buyukSayi}");

                    Console.WriteLine("Yeni sayılar girmek için bir tuşa basın, çıkmak için 'çıkış' yazın.");
                    basla = Console.ReadLine() == "çıkış" ? false : true;
                }
                else
                {
                    Console.WriteLine("Lütfen sayıları rakamlar ile girin ve kesirli sayı yazmayınız!");
                }
            }
        }
    }
}
