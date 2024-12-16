using _19_Class_Study_.Abstract;
using _19_Class_Study_.Data;

namespace _19_Class_Study_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Products
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 9900, 5),
                new Product("Phone", 8000, 10),
                new Product("Tablet", 6000, 4),
                new Product("Earbuds", 1000, 0),
                new Product("Keyboard", 1100, 15),
                new Product("Mouse", 1150, 30),
                new Product("Monitor", 2500, 2),
                new Product("Printer", 2000, 0),
                new Product("Router", 1300, 25),
                new Product("Webcam", 1450, 6)
            };
            Console.WriteLine("1 - Satıcı\t2 - Müşteri");
            string EntrySelection = Console.ReadLine();
            Console.Write("Lütfen e-posta adresini girin: ");
            string email = Console.ReadLine();
            switch (EntrySelection)
            {
                case "1":
                    User seller = new Seller(email, products);
                    seller.ShowMenu();
                    break;
                case "2":
                    User customer = new Customer(email, products);
                    customer.ShowMenu();
                    break;
                default:
                    Console.WriteLine("Hatalı bir seçim yapıldı.");
                    break;

            }
        }
    }
}
