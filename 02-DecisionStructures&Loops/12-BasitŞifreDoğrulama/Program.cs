namespace _12_BasitŞifreDoğrulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 11: Basit Şifre Doğrulama
            /*
                Kullanıcıdan bir şifre girmesini isteyin. Eğer kullanıcı doğru şifreyi girerse, "Giriş Başarılı" mesajı verin; aksi takdirde, "Hatalı Şifre" mesajı verin. Doğru şifreyi kullanıcı 3 deneme sonunda bulamazsa, "Giriş Hakkınız Sona Erdi" mesajını gösterin.
            */

            Console.WriteLine("Hoş Geldiniz, lütfen parolayı giriniz!");

            string parola = "123pass";

            for (int i = 0; i < 3;)
            {
                if (Console.ReadLine() == parola)
                {
                    Console.WriteLine("Giriş Başarılı");
                    i = 3;
                }
                else
                {
                    Console.WriteLine("Hatalı Parola");
                    i++;
                    if (i == 3)
                        Console.WriteLine("Giriş Hakkınız Sona Erdi");
                    else if (i == 2)
                    {
                        Console.WriteLine("Son bir hakkınız kaldı!");
                    }
                }
            }
        }
    }
}
