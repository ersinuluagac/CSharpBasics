namespace _01_DeğişkenlerOperatörlerTipDönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru 1
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Verilen iki tam sayıyı toplama işlemi ile birleştirip sonucu ekrana yazdıran bir program yazınız.
            Console.WriteLine("Soru 1");
            Console.WriteLine("Verilen iki tam sayıyı toplama işlemi ile birleştirip sonucu ekrana yazdıran bir program yazınız.");
            int sayi1, sayi2;
            Console.Write("Lütfen ilk sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sayıların birleştirilmiş hali: {sayi1}{sayi2}");
            #endregion
            #region Soru 2
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Bir string değişkenini integer'a çevirip 5 ile çarpan bir program yazınız.
            Console.WriteLine("Soru 2");
            Console.WriteLine("Bir string değişkenini integer'a çevirip 5 ile çarpan bir program yazınız.");
            string stringSayi = "12";
            int cevirilmisSayi = Convert.ToInt32(stringSayi);
            Console.WriteLine("String'den integer'a çevrilmiş sayının 5 ile çarpımı: {0}", cevirilmisSayi * 5);
            #endregion
            #region Soru 3
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Bir kullanıcıdan aldığı iki string sayıyı toplama işlemi yaparak sonucu ekrana yazdıran bir program yazınız.
            Console.WriteLine("Soru 3");
            Console.WriteLine("Bir kullanıcıdan aldığı iki string sayıyı toplama işlemi yaparak sonucu ekrana yazdıran bir program yazınız.");
            string stringSayi1, stringSayi2;
            Console.Write("Lütfen ilk sayıyı giriniz: ");
            stringSayi1 = Console.ReadLine();
            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            stringSayi2 = Console.ReadLine();
            Console.WriteLine("String iki sayının toplamı: {0}", Convert.ToInt32(stringSayi1) + Convert.ToInt32(stringSayi2));
            #endregion
            #region Soru 4
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Bir string sayıyı önce integer'a, sonra bu integer'ı double'a çevirip 2.5 ile çarparak sonucu ekrana yazdıran bir program yazınız.
            Console.WriteLine("Soru 4");
            Console.WriteLine("Bir string sayıyı önce integer'a, sonra bu integer'ı double'a çevirip 2.5 ile çarparak sonucu ekrana yazdıran bir program yazınız.");
            string stringSayi3 = "25";
            int stringToInt = Convert.ToInt32(stringSayi3);
            Console.WriteLine("String'den integer'a ve daha sonra double'a çevirilmiş sayının 2.5 ile çarpımının sonucu, {0}", Convert.ToDouble(stringToInt) * 2.5);
            #endregion
            #region Soru 5
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Kullanıcıdan aldığı bir sayıyı önce string'e, sonra tekrar integer'a çeviren ve bu sayıyı 10 ile toplama işlemi yaparak sonucu ekrana yazdıran bir program yazınız.
            Console.WriteLine("Soru 5");
            Console.WriteLine("Kullanıcıdan aldığı bir sayıyı önce string'e, sonra tekrar integer'a çeviren ve bu sayıyı 10 ile toplama işlemi yaparak sonucu ekrana yazdıran bir program yazınız.");
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            string stringSayi4 = Convert.ToString(sayi3);
            Console.WriteLine("Integer sayıyı önce string'e daha sonra tekrar integer'a çevirip sayıyı 10 ile toplama işleminin sonucu: {0}", Convert.ToInt32(stringSayi4) + 10);
            #endregion
            #region Soru 6
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Bir mağazada her ay 50 adet ürün satılıyor. 6 ay boyunca satılan toplam ürün miktarını hesaplayan bir program yazınız.
            Console.WriteLine("Soru 6");
            Console.WriteLine("Bir mağazada her ay 50 adet ürün satılıyor. 6 ay boyunca satılan toplam ürün miktarını hesaplayan bir program yazınız.");
            int aylikSatilanUrun = 50;
            Console.WriteLine("Her ay 50 adet ürün satan mağazının 6 aylık satış adedi: {0}", aylikSatilanUrun * 6);
            #endregion
            #region Soru 7
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Ahmet, 20 TL'sini dolara çevirmek istiyor. Dolar kuru şu anda 7.5 TL. Ahmet'in kaç dolar alabileceğini hesaplayan bir program yazınız.
            Console.WriteLine("Soru 7");
            Console.WriteLine("Ahmet, 20 TL'sini dolara çevirmek istiyor. Dolar kuru şu anda 7.5 TL. Ahmet'in kaç dolar alabileceğini hesaplayan bir program yazınız.");
            double ahmetPara = 20, dolar = 7.5;
            Console.WriteLine($"Ahmet'in 20 TL ile alabileceği dolar: {ahmetPara * dolar}");
            #endregion
            #region Soru 8
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Bir markette muzun kilogram fiyatı 15.5 TL. Hasan, 3 kg muz almak istiyor ve kasaya geldiğinde ne kadar ödemesi gerektiğini öğrenmek istiyor. Bu hesaplamayı yapan bir program yazınız.
            Console.WriteLine("Soru 8");
            Console.WriteLine("Bir markette muzun kilogram fiyatı 15.5 TL. Hasan, 3 kg muz almak istiyor ve kasaya geldiğinde ne kadar ödemesi gerektiğini öğrenmek istiyor. Bu hesaplamayı yapan bir program yazınız.");
            double muzFiyat = 15.5, muzKg = 3;
            Console.WriteLine($"Hasan'ın ödemesi gereken ücret: {muzFiyat * muzKg}");
            #endregion
            #region Soru 9
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Bir şirket, çalışanlarının maaşlarına yıllık %10 zam yapıyor. Mevcut maaşı 5000 TL olan bir çalışanın bir yıl sonraki maaşını hesaplayan bir program yazınız.
            Console.WriteLine("Soru 9");
            Console.WriteLine("Bir şirket, çalışanlarının maaşlarına yıllık %10 zam yapıyor. Mevcut maaşı 5000 TL olan bir çalışanın bir yıl sonraki maaşını hesaplayan bir program yazınız.");
            int mevcutMaas = 5000;
            double zamOrani = 1.10;
            Console.WriteLine($"Maaşı 5000 TL olan çalışanın %10 zam ile bir yıl sonra alacağı maaş {mevcutMaas * zamOrani}");
            #endregion
            #region Soru 10
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Bir kişinin doğum yılını kullanıcıdan alarak, kaç yaşında olduğunu hesaplayan ve sonucu ekrana yazdıran bir program yazınız.
            Console.WriteLine("Soru 10");
            Console.WriteLine("Bir kişinin doğum yılını kullanıcıdan alarak, kaç yaşında olduğunu hesaplayan ve sonucu ekrana yazdıran bir program yazınız.");
            Console.Write("Doğum yılınızı giriniz: ");
            int year = DateTime.Now.Year, birthYear = Convert.ToInt32(Console.ReadLine());
            int yas = year - birthYear;
            Console.WriteLine($"Yaşınız {yas}");
            #endregion
            #region Soru 11
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Bir markette müşteri üç farklı ürün alıyor. Bu ürünlerin fiyatlarını ve miktarlarını kullanıcıdan alarak toplam tutarı hesaplayan bir program yazınız.
            Console.WriteLine("Soru 11");
            Console.WriteLine("Bir markette müşteri üç farklı ürün alıyor. Bu ürünlerin fiyatlarını ve miktarlarını kullanıcıdan alarak toplam tutarı hesaplayan bir program yazınız.");
            int firstProduct, secondProduct, thirdProduct;
            double fpPrice, spPrice, tpPrice;
            Console.Write("Birinci ürünün adedi: ");
            firstProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("Birinci ürünün fiyatı: ");
            fpPrice = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("İkinci ürünün adedi: ");
            secondProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci ürünün fiyatı: ");
            spPrice = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Üçüncü ürünün adedi: ");
            thirdProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü ürünün fiyatı: ");
            tpPrice = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            double toplamTutar = (firstProduct * fpPrice) + (secondProduct * spPrice) + (thirdProduct * tpPrice);
            Console.WriteLine($"Ödenmesi gereken toplam tutar: {toplamTutar}");
            #endregion
            #region Soru 12
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Bir öğrencinin üç farklı sınav notunu kullanıcıdan alarak, sınavların ortalamasını hesaplayan ve sonucu ekrana yazdıran bir program yazınız.
            Console.WriteLine("Soru 12");
            Console.WriteLine("Bir öğrencinin üç farklı sınav notunu kullanıcıdan alarak, sınavların ortalamasını hesaplayan ve sonucu ekrana yazdıran bir program yazınız.");
            double sinavBir, sinavIki, sinavUc;
            Console.Write("Lütfen birinci sınav sonucunu giriniz: ");
            sinavBir = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Lütfen ikinci sınav sonucunu giriniz: ");
            sinavIki = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Lütfen üçüncü sınav sonucunu giriniz: ");
            sinavUc = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Sınavlarınızın ortalaması: {0}", (sinavBir + sinavIki + sinavUc) / 3);
            #endregion
            #region Soru 13
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            // Bir mağazada bir ürünün fiyatı üzerinden %20 indirim yapılmaktadır. Kullanıcıdan ürünün fiyatını alarak indirimli fiyatı hesaplayan bir program yazınız.
            Console.WriteLine("Soru 13");
            Console.WriteLine("Bir mağazada bir ürünün fiyatı üzerinden %20 indirim yapılmaktadır. Kullanıcıdan ürünün fiyatını alarak indirimli fiyatı hesaplayan bir program yazınız.");
            double indirimOrani = 20;
            Console.Write("Lütfen ürünün fiyatını giriniz: ");
            double urunFiyati = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ürünün indirimli fiyatı: {urunFiyati * ((100 - indirimOrani) / 100)}");
            #endregion
            #region Soru 14
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Kullanıcıdan bir miktar Euro ve güncel Euro kuru bilgilerini alarak, kaç TL'ye karşılık geldiğini hesaplayan bir program yazınız.
            Console.WriteLine("Soru 14");
            Console.WriteLine("Kullanıcıdan bir miktar Euro ve güncel Euro kuru bilgilerini alarak, kaç TL'ye karşılık geldiğini hesaplayan bir program yazınız.");
            double euro, euroKur, euroTL;
            Console.Write("Lütfen Euro miktarını giriniz: ");
            euro = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Lütfen Euro kurunu giriniz: ");
            euroKur = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            euroTL = euro * euroKur;
            Console.WriteLine("Euro'nuzun TL karşılığı: {0}", euroTL);
            #endregion
        }
    }
}
