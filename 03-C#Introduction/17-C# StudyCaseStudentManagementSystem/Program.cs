using System.Linq;

namespace _17_C__StudyCaseStudentManagementSystem
{
    internal class Program
    {
        static List<int> studentIds = new List<int>();
        static List<string> firstNames = new List<string>();
        static List<string> lastNames = new List<string>();
        static List<int> ages = new List<int>();
        static List<double> averageGrades = new List<double>();
        static string filePath = @"C:\Users\ersin\OneDrive\Masaüstü\BA";
        static string studentPath = @"C:\Users\ersin\OneDrive\Masaüstü\BA\Students.txt";
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("İşlem seçin:");
            Console.WriteLine("1 - Öğrenci Ekle\t\t2 - Öğrencileri Listele\n3 - Öğrenci Sil\t\t\t4 - Öğrenci Bul\n5 - Öğrencileri Dosyaya Kaydet\t6 - Öğrenci Dosyasını Sil\n0 - Çıkış");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    GetStudent();
                    break;
                case "2":
                    ShowStudents();
                    break;
                case "3":
                    SelectStudent();
                    break;
                case "4":
                    SearchByLastName();
                    break;
                case "5":
                    SaveToFile();
                    break;
                case "6":
                    DeleteFromFile();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Hatalı bir seçim yapıldı.");
                    Start();
                    break;
            }
        }
        static void GetStudent()
        {
            GetId();
            GetName();
            GetSurname();
            GetAge();
            GetAvgGrades();
            Console.Clear();
            Start();

            // Functions
            void GetId()
            {
                Console.Write("Lütfen Öğrenci ID girin: ");
                if (int.TryParse(Console.ReadLine().Trim(), out int Id))
                {
                    if (Id > 999 && Id < 10000 && !studentIds.Contains(Id))
                    {
                        studentIds.Add(Id);
                        Console.WriteLine("Öğrenci ID kaydedildi.");
                    }
                    else if (studentIds.Contains(Id))
                    {
                        Console.WriteLine("Bu öğrenci ID zaten mevcut");
                        GetId();
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 4 haneli bir ID girin.");
                        GetId();
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen öğrenci ID'sini rakamlarla girin.");
                    GetId();
                }
            }
            void GetName()
            {
                Console.Write("Lütfen öğrenci ismini girin: ");
                firstNames.Add(Console.ReadLine().ToUpper().Trim());
                Console.WriteLine("Öğrenci ismi kaydedildi.");
            }
            void GetSurname()
            {
                Console.Write("Lütfen öğrenci soyismini girin: ");
                lastNames.Add(Console.ReadLine().ToUpper().Trim());
                Console.WriteLine("Öğrenci soyismi kaydedildi.");
            }
            void GetAge()
            {
                Console.Write("Lütfen öğrencinin yaşını girin: ");
                if (int.TryParse(Console.ReadLine().Trim(), out int age))
                {
                    if (age > 7 && age < 50)
                    {
                        ages.Add(age);
                        Console.WriteLine("Öğrencinin yaşı kaydedildi.");
                    }
                    else
                    {
                        Console.WriteLine("Öğrencinin yaşı kurs için uygun değil.");
                        GetAge();
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen öğrenci yaşını rakamlarla girin.");
                    GetAge();
                }
            }
            void GetAvgGrades()
            {
                int i = 1;
                double totalNote = 0;
                do
                {
                    Console.Write($"Lütfen {i}. notu girin: ");
                    if (double.TryParse(Console.ReadLine(), out double note))
                    {
                        if (note <= 100 && note >= 0)
                        {
                            totalNote += note;
                            i++;
                            Console.WriteLine("Yeni bir not eklemek için bir tuşa basın, ortalamayı kaydetmek için 0'a basın.");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci notu 0 ile 100 arasında olmalı.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen notu rakamlarla girin.");
                    }
                } while (Console.ReadLine() == "0" ? false : true);
                averageGrades.Add(totalNote / i);
            }
        }
        static void ShowStudents()
        {
            Console.Clear();
            for (int i = 0; i < studentIds.Count; i++)
            {
                Console.WriteLine($"ID: {studentIds[i]}\t Name: {firstNames[i]} {lastNames[i]}\t Age: {ages[i]}\t Average: {averageGrades[i]}");
            }
            Start();
        }
        static void SelectStudent()
        {
            Console.Write("Lütfen silmek istediğiniz öğrencinin soyadını girin: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (studentIds.Contains(id))
                {
                    int index = studentIds.IndexOf(id);
                    DeleteStudent(index);
                }
                else
                {
                    Console.WriteLine("Böyle bir öğrenci bulunamadı.");
                    Start();
                }
            }
            else
            {
                Console.WriteLine("Lütfen öğrenci ID'sini rakamlarla girin.");
            }
            void DeleteStudent(int index)
            {
                studentIds.RemoveAt(index);
                firstNames.RemoveAt(index);
                lastNames.RemoveAt(index);
                ages.RemoveAt(index);
                averageGrades.RemoveAt(index);
            }
        }
        static void SearchByLastName()
        {
            Console.Write("Lütfen aramak istediğiniz öğrencinin soyadını girin:");
            string lastName = Console.ReadLine().ToUpper().Trim();
            if (lastNames.Contains(lastName))
            {
                int index = lastNames.IndexOf(lastName);
                Console.WriteLine($"ID: {studentIds[index]}\t Name: {firstNames[index]} {lastNames[index]}\t Age: {ages[index]}\t Average: {averageGrades[index]}");
            }
            Start();
        }
        static void SaveToFile()
        {
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
            if (!File.Exists(studentPath))
                File.Create(studentPath);
            if (studentIds.Count > 0)
            {
                List<string> students = new List<string>();
                for (int i = 0; i < studentIds.Count; i++)
                {
                    students.Add($"ID: {studentIds[i]},\t Name: {firstNames[i]} {lastNames[i]},\t Age: {ages[i]},\t Avg Grades: {averageGrades[i]}");
                }
                File.WriteAllLines(studentPath, students);
            }
            else
            {
                Console.WriteLine("Öğrenci listesi boş.");
            }
        }
        static void DeleteFromFile()
        {
            if (Directory.Exists(filePath))
            {
                Console.WriteLine("Klasör silindi.");
                Directory.Delete(filePath);
            }
            if (File.Exists(studentPath))
            {
                Console.WriteLine("Dosya silindi.");
                File.Delete(studentPath);
            }
        }
    }
}
