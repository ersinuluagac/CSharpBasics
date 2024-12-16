using System.Diagnostics;

namespace _16_C_IntroductionBitirmeProjesi
{
    internal class Program
    {
        static double stepLength;
        static List<double> stepPerMinute = new List<double>();
        static List<int> runningTime = new List<int>();
        static List<double> avgRunningDistance = new List<double>();
        static void Main(string[] args)
        {
            #region Ödev & Açıklaması
            // Boost Proje: Günlük Koşu Mesafesi Ölçer
            /*
             * Yeni akıllı saatler olmadan günlük koşu mesafemizi ölçebilir miyiz? Sizden günlük koşu mesafemizi ölçen bir yazılım yapmanızı istiyorum. Yapacağınız yazılıma; sizin adım boyunuzu, bir dakikada kaç adım attığınızı ve toplam koşu sürenizi belirtiğinizde size metre cinsinden toplam koşu mesafenizi söyleyecek.
             * Yapacağınız çözümü modüllere bölmeyi unutmayın.
             * Veriyi 4 adımda alacağız:
                1. Ortalama bir adımınızın kaç santimetre olduğunu gireceksiniz
                2. Bir dakikada kaç adım koştuğunuzu gireceksiniz.
                3. Koşu süresini
                    3.1. Önce saat
                    3.2. Ve dakika olarak gireceksiniz.
             * Lütfen her adımda verilerin doğruluğunu kontrol etmeyi unutmayın.
             // EK Soru:
             * Koşuyu aynı hızda koşmam mümkün olmayacağından koşunun belli bölümlerinde dakikada kaç adım attığımı girebileceğim bir farklı tasarım yapabilir misiniz?
            */
            #endregion
            #region Program Açıklaması
            /* 
             * Program Start() metodu ile başlar.
             * Kullanıcıdan adım boyunu, dakikada kaç adım attığını, koşu süresinin saatini ve koşu süresinin dakikasını alır.
             * Eğer kullanıcı yeni bir periyod eklemek isterse "0" hariç herhangi bir tuşa basar ve dakikada kaç adım attığı, koşu süresinin saati ve koşu süresinin dakikası alınır.
             * Kullanıcı döngüden çıkmak için "0" bastığı zaman List elemanları ile hesaplama yapılır ve ortalama alınarak kaydedilir.
             * Program yeniden başlatılır ve ortalama koşu mesafeleri en üste yazdırılır.
             * Kullanıcı artık "Adım Boyu Sıfırla" ve "Geçmişi Temizle" seçeneklerine de sahip olur.
             * Eğer adım boyunu sıfırlamazsa adım boyu bilgisi alınmadan tekrar diğer bilgiler alınarak hesaplama yapılabilir.
             * Adım boyu sıfırlama seçeneği farklı kişilerin koşu mesafelerini de hesaplamak için eklenmiştir.
            */
            #endregion
            Start();
        }
        // Başlangıç Metodu
        /// <summary>
        /// Başlangıç metodu. 2 veya 4 işlem arasından birisinin seçilmesi ile işlem seçilmesini sağlar.
        /// </summary>
        static void Start()
        {
            // Geçmişi silmek için fonksiyon
            void ClearHistory()
            {
                avgRunningDistance.Clear();
                Console.Clear();
                Start();
            }

            // Hesaplama işlemi adım boyu bilgisi olmadan yapılıyorsa "Hesapla", eğer daha önce adım boyu bilgisi girildiyse "Yeniden Hesapla" olarak değişir.
            string processName = "Hesapla";
            string StepLengthProcess = null;
            string clearHistoryProcess = null;
            if (stepLength > 0)
            {
                processName = "Yeniden Hesapla";
                StepLengthProcess = "2 - Adım Boyunu Sıfırla\t";
            }

            // Eğer daha önce bir hesaplama varsa başlangıçta gösterilecek
            if (avgRunningDistance.Count > 0)
            {
                if (stepLength > 0) // Adım boyu mevcutsa geçmişi temizle 3. seçenek, adım boyu mevcut değilse 2. seçenek
                    clearHistoryProcess = "3 - Geçmişi Temizle\t";
                else
                    clearHistoryProcess = "2 - Geçmişi Temizle\t";
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Önceki koşu mesafeleriniz:");
                for (int i = 0; i < avgRunningDistance.Count; i++)
                {
                    Console.Write($"{i + 1} - {avgRunningDistance[i]} metre\t");
                    if (i == avgRunningDistance.Count - 1)
                    {
                        Console.WriteLine();
                    }
                }
                Console.ResetColor();
            }

            // Program başlangıc ekranı.
            Console.Title = "Günlük Koşu Mesafesi Ölçer";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(new string('*', 10) + " Günlük Koşu Mesafesi Ölçer " + new string('*', 10));
            Console.ResetColor();
            Console.WriteLine($"1 - {processName}\t{StepLengthProcess}{clearHistoryProcess}0 - Çıkış\t");
            string start = Console.ReadLine().Trim();
            switch (start)
            {
                case "1":
                    // Hesaplama İşlemleri
                    CalculateRunningDistance();
                    break;
                case "2":
                    // Adım sıfırlama işlemleri
                    if (stepLength > 0)
                    {
                        stepLength = 0;
                        Console.Clear();
                        Start();
                        break;
                    }
                    else
                    {
                        if (avgRunningDistance.Count > 0)
                        {
                            ClearHistory();
                            break;
                        }
                        else
                            ShowChoiceError();
                            break;
                    }
                case "3":
                    // Geçmişi temizleme işmeleri
                    if (stepLength > 0)
                    {
                        if (avgRunningDistance.Count > 0)
                        {
                            ClearHistory();
                            break;
                        }
                        else
                        {
                            ShowChoiceError();
                            break;
                        }
                    }
                    else
                    {
                        ShowChoiceError();
                        break;
                    }
                case "0":
                    // Çıkış
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nProgramdan çıkılıyor...");
                    Console.ResetColor();
                    break;
                default:
                    // İşlem Seçim Hatası
                    ShowChoiceError();
                    break;
            }
        }

        // Hata Mesajları
        /// <summary>
        /// Konsolda, menüde seçilen işlemin hatalı olması durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowChoiceError()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hatalı bir işlem seçildi! Lütfen yapmak istediğiniz işlemin kodunu seçin.");
            Console.ResetColor();
            Start();
        }
        /// <summary>
        /// Konsolda, değerlerin rakam ile girilmemesi durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowDigitError()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Lütfen değeri rakamlarla giriniz.\n");
            Console.ResetColor();
        }
        /// <summary>
        /// Konsolda, girilen değerin sıfır veya sıfırdan küçük olması durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowZeroError()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Girilen değer sıfır veya sıfırdan küçük olamaz.\n");
            Console.ResetColor();
        }
        /// <summary>
        /// Konsolda, girilen değerin sıfırdan küçük olması durumundaki hata mesajını gösterir.
        /// </summary>
        static void ShowLessZeroError()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bir hata oldu! Girilen değer sıfırdan küçük olamaz.\n");
            Console.ResetColor();
            GetRunningTimeHours();
        }

        // Değerlerin Alınması
        /// <summary>
        /// Kullanıcıdan adım boyu almak için kullanılır. Rakam girişi, sıfır ve sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir. Alınan değeri konsolda yazdırır ve değişkene atar.
        /// </summary>
        static void GetStepLength()
        {
            Console.Write("Lütfen santimetre cinsinden adım boyunuzu girin: ");
            if (double.TryParse(Console.ReadLine(), out stepLength))
            {
                if (stepLength > 0)
                {
                    Console.WriteLine($"Adım boyunuz kaydedildi... {stepLength}cm\n");
                }
                else
                {
                    ShowZeroError();
                    GetStepLength();
                }
            }
            else
            {
                ShowDigitError();
                GetStepLength();
            }
        }
        /// <summary>
        /// Kullanıcıdan dakika başına kaç adım attığını almak için kullanılır. Rakam girişi, sıfır ve sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir. Alınan değeri konsola yazdırır ve list öğesine kaydeder.
        /// </summary>
        static void GetStepPerMinute()
        {
            Console.Write("Lütfen dakikada kaç adım attığınızı girin: ");
            if (double.TryParse(Console.ReadLine(), out double _stepPerMinute))
            {
                if (_stepPerMinute > 0)
                {
                    stepPerMinute.Add(_stepPerMinute);
                    Console.WriteLine($"Dakika başına atılan adımız kaydedildi... {_stepPerMinute}\n");
                }
                else
                {
                    ShowZeroError();
                    GetStepPerMinute();
                }
            }
            else
            {
                ShowDigitError();
                GetStepPerMinute();
            }
        }
        /// <summary>
        /// Kullanıcının koşu süresi saatini almak ve dakika olarak bir değişkene atamak, daha sonra bu değişkeni parametre olarak vererek GetRunningTimeMinutes metodunu çağırmak için kullanılır. Rakam girişi, sıfır veya sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir.
        /// </summary>
        static void GetRunningTimeHours()
        {
            Console.Write("Lütfen koşu sürenizin saatini girin: ");
            if (int.TryParse(Console.ReadLine(), out int _runningTimeHours)) // Koşu süresinin saat bölümü
            {
                if (_runningTimeHours >= 0)
                {
                    _runningTimeHours *= 60;
                    GetRunningTimeMinutes(_runningTimeHours);
                }
                else
                {
                    ShowLessZeroError(); // Saat için sıfır girilmesi mümkün olabileceği için negatif sayı girişini engeller.
                    GetRunningTimeHours();
                }
            }
            else
            {
                ShowDigitError();
                GetRunningTimeHours();
            }
        }
        /// <summary>
        /// Kulanıcının koşu süresi dakikası almak için kullanılır. Alınan dakika parametre olarak gelen saat ile birlikte list öğesine eklenir, konsolda toplam süre dakika olarak gösterilir. Rakam girişi, sıfır veya sıfırdan küçük sayı girişi kontrolü yapılır; hatalı girişlerde uygun hata mesajını gösterir.
        /// </summary>
        /// <param name="runnigTimeHours"></param>
        static void GetRunningTimeMinutes(int runnigTimeHours)
        {
            Console.Write("Lütfen koşu sürenizin dakikasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int _runningTimeMinutes)) // Koşu süresinin dakika bölümü
            {
                if (runnigTimeHours > 0)
                {
                    if (_runningTimeMinutes >= 0)
                    {
                        GetMinutes();
                    }
                    else
                    {
                        ShowLessZeroError(); // Eğer saat sıfırdan büyük ise negatif sayı girişini engeller ama sıfır kabul edilir.
                        GetRunningTimeMinutes(runnigTimeHours);
                    }
                }
                else
                {
                    if (_runningTimeMinutes > 0)
                    {
                        GetMinutes();
                    }
                    else
                    {
                        ShowZeroError();
                        GetRunningTimeMinutes(runnigTimeHours);
                    }
                }
            }
            else
            {
                ShowDigitError();
                GetRunningTimeMinutes(runnigTimeHours);
            }

            // Dakika girişini kaydetmek için fonksiyon
            void GetMinutes()
            {
                int _runningTime = runnigTimeHours + _runningTimeMinutes;
                runningTime.Add(_runningTime);
                Console.WriteLine($"Koşu süreniz kaydedildi... {_runningTime} dakika\n");
            }
        }

        // Hesaplama
        /// <summary>
        /// Kullanıcıdan değer alan metotları çalıştırır ve kullanıcı çıkana kadar döngüye sokar, daha sonra toplam koşu mesafesini hesaplar ve atama yapar. İşlemler bittikten sonra tekrar başlangıç metodunu çalıştırır ve son hesaplamanını periyotlarını ekranın en üstüne yazdırır.
        /// </summary>
        static void CalculateRunningDistance()
        {
            // Eğer yoksa adım boyu ve dakika başı adım ile koşu süresi alma döngüsü.
            do
            {
                if (stepLength <= 0) // Adım boyu mevcutsa GetStepLength atlanır.
                    GetStepLength();
                GetStepPerMinute();
                GetRunningTimeHours();
                Console.Write("Yeni bir koşu periyodu eklemek için bir tuşa basın, sonucu görmek için \"0\"ı tuşlayın: ");
            } while (Console.ReadLine() == "0" ? false : true);

            // Alınan değerlerin hesaplanması
            double runningDistance = 0;
            if (stepPerMinute.Count == runningTime.Count)
            {
                for (int i = 0; i < stepPerMinute.Count; i++)
                {
                    runningDistance += stepLength * stepPerMinute[i] * runningTime[i];
                }
                // Ekrana yazdırma
                avgRunningDistance.Add(Math.Round(runningDistance / 100, 3)); // Koşu mesafesi ondalıklı olarak (3 hane) metre cinsinden kaydedilir.
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Son koşunuzun detayları:");
                Console.WriteLine($"Adım boyunuz: {stepLength}cm");
                for (int i = 0; i < stepPerMinute.Count;i++) // Koşu periyotlarında koşulan mesafe ekrana yazılır.
                {
                    Console.WriteLine($"Koşu periyodu {i + 1} | Dakika başı adım: {stepPerMinute[i]}, Koşu süresi: {runningTime[i]} dakika, Koşulan mesafe: {(stepLength * stepPerMinute[i] * runningTime[i]) / 100}m");
                }
                Console.ResetColor();
                stepPerMinute.Clear();
                runningTime.Clear();
                Start();
                }
            else // stepPerMinute ve runnigTime eleman sayılar eşit değilse çalışacak. Bütün geçmişi temizler. Girişi engellendi(???).
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Bir hata oluştu! Girilen dakika başı adım ve koşu süresi sayısı uyuşmuyor, program tekrar başlatılıyor.");
                Console.ResetColor();
                stepPerMinute.Clear();
                runningTime.Clear();
                Start();
            }
        }
    }
}
