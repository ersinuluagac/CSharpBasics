namespace _07_BasitMenüSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 6: Basit Menü Sistemi 
            /*
                Kullanıcıya 4 seçenek sunan bir menü oluşturun:
                1. Toplama
                2. Çıkarma
                3. Çarpma
                4. Bölme
                Kullanıcı menüden bir seçenek seçtikten sonra, iki sayı alarak seçilen işlemi yapın ve sonucu ekrana yazdırın. Kullanıcı "çıkış" seçeneğini seçene kadar menüyü tekrar tekrar gösterin.
            */

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('/', 15) + "Menüye Hoş Geldiniz" + new string('\\', 15));
            Console.ResetColor();

            double sayi1, sayi2;
            int islem;
            bool basla = true;

            while (basla)
            {
                Console.Write("Lütfen yapmak istediğiniz işlemin numarasını girin: 1 [Toplama] - 2 [Çıkarma] - 3 [Çarpma] - 4 [Bölme]: ");
                int.TryParse(Console.ReadLine(), out islem);

                if (islem > 0 && islem < 5)
                {
                    Console.Write("Lütfen ilk sayıyı girin: ");
                    bool donusSayi1 = double.TryParse(Console.ReadLine(), out sayi1);
                    Console.Write("Lütfen ikinci sayıyı girin: ");
                    bool donusSayi2 = double.TryParse(Console.ReadLine(), out sayi2);

                    if (donusSayi1 && donusSayi2)
                    {
                        switch (islem)
                        {
                            case 1:
                                Console.WriteLine($"İşlem Sonucu: {sayi1 + sayi2}");
                                break;
                            case 2:
                                Console.WriteLine($"İşlem Sonucu: {sayi1 - sayi2}");
                                break;
                            case 3:
                                Console.WriteLine($"İşlem Sonucu: {sayi1 * sayi2}");
                                break;
                            case 4:
                                if (sayi2 != 0)
                                    Console.WriteLine($"İşlem Sonucu: {sayi1 / sayi2}");
                                else
                                    Console.WriteLine("Sayı sıfıra bölünemez!");
                                break;
                            default:
                                Console.WriteLine("Bir hata oluştu!");
                                break;
                        }
                        Console.WriteLine("Yeni bir işlem yapmak için bir tuşa basın, çıkış yapmak için 'çıkış' yazmanız yeterli");
                        basla = Console.ReadLine() == "çıkış" ? false : true;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sayıları sadece rakamlar ile girin!");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız! Lütfen işlem numaralarından birini seçin!");
                }
            }
        }
    }
}
