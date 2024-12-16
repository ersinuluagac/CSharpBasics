namespace _02_BasitHesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 1: Basit Hesap Makinesi
            /*
                 Kullanıcıdan iki sayı ve bir işlem türü (+, -, *, /) alın. Girilen işleme göre iki sayının sonucunu ekrana yazdıran bir program yazın. Eğer kullanıcı geçersiz bir işlem girerse, uygun bir hata mesajı gösterin.
            */

            //Console Design
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new string('-', 15) + "Hesap Makinesi" + new string('-', 15));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Variables Declarations
            double sayi1, sayi2, sonuc = 0;
            int islem;
            bool basla = true;

            //Loop for calculations
            while (basla)
            {
                Console.Write("Lütfen yapılacak işlemin numarasını seçin: 1-Toplama[+], 2-Çıkartma[-], 3-Çarpma[*], 4-Bölme[/]: ");
                int.TryParse(Console.ReadLine(), out islem);
                if (islem > 0 && islem < 5)
                {
                    Console.Write("Lütfen işlem yapmak istediğiniz ilk sayıyı giriniz: ");
                    bool donus1 = double.TryParse(Console.ReadLine(), out sayi1);
                    Console.Write("Lütfen işlem yapmak istediğiniz ikinci sayıyı giriniz: ");
                    bool donus2 = double.TryParse(Console.ReadLine(), out sayi2);
                    if (donus1 == true && donus2 == true)
                    {
                        switch (islem)
                        {
                            case 1:
                                sonuc = sayi1 + sayi2;
                                break;
                            case 2:
                                sonuc = sayi1 - sayi2;
                                break;
                            case 3:
                                sonuc = sayi1 * sayi2;
                                break;
                            case 4:
                                if (sayi2 != 0)
                                    sonuc = sayi1 / sayi2;
                                else
                                    Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Bir sayı sıfıra bölünemez!");
                                Console.Beep();
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;

                        }
                        if (sayi2 != 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Yaptığınız işlemin sonucu: {sonuc}");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? [evet] [hayır]");
                        basla = Console.ReadLine() == "evet" ? true : false;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı bir giriş yaptınız. Lütfen işlem yapmak istediğiniz sayıları sadece rakamlarla giriniz!");
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı bir giriş yaptınız. Lütfen ekrandaki işlem numaralarından sadece birisini rakamla giriniz!");
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}
