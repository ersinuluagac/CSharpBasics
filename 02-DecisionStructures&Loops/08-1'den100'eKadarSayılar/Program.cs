namespace _08_1_den100_eKadarSayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 7: 1'den 100'e Kadar Sayıları Yazdırma
            /*
                 Bir for döngüsü kullanarak 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazın.
            */

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
