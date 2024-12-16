namespace _15_BasitATMSimülasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev Bonus: Basit ATM Simülasyonu
            /*
				Senaryo: Bir ATM makinesi için basit bir simülasyon yazılımı geliştireceksiniz. Kullanıcı başlangıçta bir PIN kodu ile giriş yapacak. Başarılı bir girişten sonra kullanıcıya bir menü sunulacak. Menüde aşağıdaki işlemler yer alacak:
				1. Bakiye Görüntüle: Kullanıcının mevcut bakiyesini gösterir.
				2. Para Çek: Kullanıcının hesabından para çekmesini sağlar.
				3. Para Yatır: Kullanıcının hesabına para yatırmasını sağlar.
				4. Çıkış: Programdan çıkış yapar.

				Detaylar:
				* Başlangıçta kullanıcının hesabında 1000 TL bakiye bulunacak.
				* Kullanıcı doğru PIN kodunu girene kadar 3 deneme hakkına sahip olacak. Yanlış girişlerde "Hatalı PIN, tekrar deneyin" mesajı gösterilecek. 3. hatalı girişten sonra program sonlandırılacak.
				* Para çekme işlemi sırasında, kullanıcı mevcut bakiyesinden fazla para çekmeye çalışırsa, "Yetersiz bakiye" mesajı gösterilecek ve işlem yapılmayacak.
				* Para yatırma ve çekme işlemleri sonrasında kullanıcının güncel bakiyesi gösterilecek.
				* Kullanıcı, "Çıkış" seçeneğini seçene kadar menü tekrar tekrar gösterilecek.

				Çözüm İpuçları:
				* Programda, kullanıcı girişini ve işlemleri kontrol etmek için while ve if yapıları kullanılabilir.
				* İşlemler, kullanıcıdan alınan girişlere göre yapılmalıdır.
				* Bakiye işlemleri için değişkenler ve basit matematiksel operatörler kullanılabilir.

				Bu senaryo, öğrencilerin öğrendikleri tüm temel C# yapılarını bir arada kullanmalarını sağlayacak ve aynı zamanda problem çözme becerilerini geliştirecek.
			*/

            // Konsol
            Console.Title = "ABC Bank";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new string('*', 15) + "ABC Bank" + new string('*', 15));
            Console.ResetColor();

            // Değişkenler
            double bakiye = 1000, artiBakiye, eksiBakiye;
            ushort sifre = 2357;
            byte islem;
            int denemeSifre;

            // Şifre Doğrulama
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Lütfen 4 haneli kart şifrenizi girin: ");
                bool donusSifre = int.TryParse(Console.ReadLine(), out denemeSifre);
                if (donusSifre)
                {
                    // Doğru Şifre İşlemleri
                    if (sifre == denemeSifre)
                    {
                        // ATM İşlemleri Başla
                        bool islemSecildi = true;
                        while (islemSecildi)
                        {
                            Console.WriteLine("Yapmak istediğiniz işlemi seçin: ");
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("1 - Bakiye Görüntüle | 2 - Para Çek | 3 - Para Yatır | 4 - Çıkış");
                            Console.ResetColor();
                            bool donusIslem = byte.TryParse(Console.ReadLine(), out islem);
                            // Seçilecek İşlem Doğrulaması
                            if (donusIslem)
                            {
                                switch (islem)
                                {
                                    // Bakiye Görüntüleme İşlemleri
                                    case 1:
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine($"Şu anki bakiyeniz: {bakiye}");
                                        Console.ResetColor();
                                        break;
                                    // Para Çekme İşlemleri
                                    case 2:
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine($"Bakiye: {bakiye}");
                                        Console.WriteLine("Çekmek istediğiniz tutarı girin: ");
                                        Console.ResetColor();
                                        bool islem2 = true;
                                        // Para Çekme Döngüsü
                                        while (islem2)
                                        {
                                            bool donusEksi = double.TryParse(Console.ReadLine(), out eksiBakiye);
                                            // Para Çekme Girdi Kontrolü
                                            if (donusEksi)
                                            {
                                                if (bakiye >= eksiBakiye)
                                                {
                                                    bakiye -= eksiBakiye;
                                                    Console.BackgroundColor = ConsoleColor.Green;
                                                    Console.ForegroundColor = ConsoleColor.Black;
                                                    Console.WriteLine($"Önceki bakiyeniz: {bakiye + eksiBakiye} | Çekilen tutar: {eksiBakiye} | Şu anki bakiyeniz: {bakiye}");
                                                    Console.ResetColor();
                                                    islem2 = false;
                                                }
                                                else
                                                {
                                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                                    Console.ForegroundColor = ConsoleColor.Black;
                                                    Console.WriteLine("Yetersiz bakiye!");
                                                    Console.WriteLine($"Bakiye: {bakiye}");
                                                    Console.WriteLine("Çekmek istediğiniz tutarı girin: ");
                                                    Console.ResetColor();
                                                }
                                            }
                                            else
                                            {
                                                Console.BackgroundColor = ConsoleColor.Yellow;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("Lütfen çekmek istediğiniz tutarı raklamlarla girin!");
                                                Console.ResetColor();
                                            }
                                        }
                                        break;
                                    // Para Yatırma İşlemleri
                                    case 3:
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine($"Bakiye: {bakiye}");
                                        Console.WriteLine("Yatırmak istediğiniz tutarı girin: ");
                                        Console.ResetColor();
                                        bool islem3 = true;
                                        // Para Yatırma Döngüsü
                                        while (islem3)
                                        {
                                            bool donusArti = double.TryParse(Console.ReadLine(), out artiBakiye);
                                            // Para Yatırma Girdi Kontrolü
                                            if (donusArti)
                                            {
                                                bakiye += artiBakiye;
                                                Console.BackgroundColor = ConsoleColor.Green;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine($"Önceki bakiyeniz: {bakiye - artiBakiye} | Yatırılan tutar: {artiBakiye} | Şu anki bakiyeniz: {bakiye}");
                                                Console.ResetColor();
                                                islem3 = false;
                                            }
                                            else
                                            {
                                                Console.BackgroundColor = ConsoleColor.Yellow;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("Lütfen yatırmak istediğiniz tutarı raklamlarla girin!");
                                                Console.ResetColor();
                                            }
                                        }
                                        break;
                                    // Çıkış İşlemleri
                                    case 4:
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("ATM'den çıkılıyor... İyi günler...");
                                        Console.ResetColor();
                                        islemSecildi = false;
                                        i = 3;
                                        break;
                                    // Hatalı Giriş
                                    default:
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Lütfen seçeneklerden birisini seçin!");
                                        Console.ResetColor();
                                        break;
                                }
                            }
                            // Seçilen İşlem Girişi Hatası
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Lütfen işlemi rakamlarla seçin!");
                                Console.ResetColor();
                            }
                        }
                    }
                    // Hatalı Şifre İşlemleri
                    else
                    {
                        // Hatalı Şifre 3 Hak Dolunca
                        if (i == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Şifrenizi 3 kere hatalı girdiniz! İşlem sonlandırılıyor...");
                            Console.Beep();
                            Console.ResetColor();
                            break;
                        }
                        // Hatalı Şifre Tekrar Dene
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Hatalı şifre! Tekrar deneyin... Kalan hak: {3 - i}");
                            Console.ResetColor();
                        }
                    }
                }
                // Şifre Giriş Hatası
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Lütfen şifrenizi rakamlarla girin!");
                    Console.Beep();
                    Console.ResetColor();
                    i--;
                }
            }
        }
    }
}
