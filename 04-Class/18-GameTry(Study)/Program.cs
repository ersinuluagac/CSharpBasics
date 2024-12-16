using System.Reflection.PortableExecutable;

namespace _18_GameTry_Study_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        /// <summary>
        /// Oyunun başlangıç menüsüdür. 1.5 saniyelik bir bildirim gösterir ve menüyü açar.
        /// </summary>
        static void Start()
        {
            // Console Design
            Console.Title = "Dungeon Master";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oyuna hoş geldiniz. Bu oyun metin tabanlı bir FRP'dir. Deneme amacıyla yapılmıştır.");
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ne yapmak istiyorsunuz?");
            Console.WriteLine("1 - Başla\t 2 - Çık");
            Console.ResetColor();

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // Oyun Başlatılır
                    Character character = new Character(GetCharacterName(), GetCharacterType());
                    Monster monster = new Monster(GetMonsterDifficulty());
                    Console.WriteLine("1 - Saldır\tDiğer - Kaç");
                    bool attackOrRun = Console.ReadLine() == "1" ? true : false;
                    while (attackOrRun)
                    {
                        Console.Clear();

                        character.HealthPoint -= (monster.AttackPoint  - character.ArmorPoint);
                        monster.HealthPoint -= character.AttackPoint;

                        Console.WriteLine($"Merhaba {character.Name}.\nKarakter: {character.CharacterType}, Can: {character.HealthPoint}\nRakip: {monster.Name}, Can: {monster.HealthPoint}");

                        if (monster.HealthPoint <= 0 || character.HealthPoint <= 0)
                        {
                            attackOrRun = false;

                        }
                        else
                        {
                            attackOrRun = Console.ReadLine() == "1" ? true : false;
                        }
                    }
                    break;
                case "2":
                    // Konsol Kapatılır
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lütfen bir geçerli seçenek seçin");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Start();
                    break;
            }
        }

        /// <summary>
        /// Karakter adını almak için metot.
        /// </summary>
        /// <returns>string bir değer döner, boş dönemez.</returns>
        static string GetCharacterName()
        {
            Console.Write("Lütfen kullanıcı adı girin: ");
            string name = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                return GetCharacterName();
            }
        }
        /// <summary>
        /// Karakter tipini almak için metot.
        /// </summary>
        /// <returns>int bir değer döner.</returns>
        static int GetCharacterType()
        {
            Console.Write("Lütfen karakter seçin: 1 - Savaşçı\t2 - Büyücü:\t");
            if (int.TryParse(Console.ReadLine(), out int characterType))
            {
                switch (characterType)
                {
                    case 1:
                        Console.WriteLine("Savaşçı karakteriniz yaratıldı.");
                        return characterType;
                        break;
                    case 2:
                        Console.WriteLine("Büyücü karakteriniz yaratıldı.");
                        return characterType;
                        break;
                    default:
                        return GetCharacterType();
                }
            }
            else
            {
                return GetCharacterType();
            }
        }
        /// <summary>
        /// Oyunun zorluk seviyesini alak için metot.
        /// </summary>
        /// <returns>string zorluk seviyesi döner.</returns>
        static string GetMonsterDifficulty()
        {
            Console.Write("Zorluk seviyesi seçin: \t1 - Easy\t|\t2 - Medium\t|\t3 - Hard:\t");
            if (int.TryParse(Console.ReadLine(), out int difficulty))
            {
                return difficulty == 1 ? "Easy" :
                       difficulty == 2 ? "Medium" : "Hard";
            }
            else
            {
                return GetMonsterDifficulty();
            }
        }
    }
}
