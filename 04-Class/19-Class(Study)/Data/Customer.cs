using _19_Class_Study_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Data
{
    public class Customer : User, ICustomerService
    {
        // Fields
        private string _email;
        private List<Product> _products;
        private List<Product> _cart;


        // Constructor
        public Customer(string email, List<Product> products) : base(email)
        {
            Email = email;
            _products = products;
            _cart = new List<Product>();
        }


        // Properties
        public string Email
        {
            get
            {
                return _email.Split('@')[0];
            }
            set
            {
                _email = value.ToLower();
            }
        }


        // Override Method
        public override void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Hoş geldin {Email}.\n");
            Console.WriteLine("1 - Ürünleri İncele ve Sepete Ekle\t2 - Sepeti Görüntüle");
            string MenuSelection = Console.ReadLine();
            switch (MenuSelection)
            {
                case "1":
                    AddToCart();
                    break;
                case "2":
                    ViewCart();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geçersiz bir işlem seçildi...");
                    Thread.Sleep(500);
                    Console.ResetColor();
                    Console.Clear();
                    ShowMenu();
                    break;
            }
        }


        //Methods
        public void ListProductsInStock()
        {
            Console.Clear();
            foreach (Product product in _products)
            {
                if (product.Stock >= 1 && product.Stock < 6)
                {
                    Console.WriteLine($"Id: {product.Id}\t İsim: {product.Name}\t Fiyat {product.Price}\t {product.Status}");
                }
                else if (product.Stock >= 6)
                {
                    Console.WriteLine($"Id: {product.Id}\t İsim: {product.Name}\t Fiyat {product.Price}\t");
                }
                else
                {
                    Console.WriteLine($"Id: {product.Id}\t İsim: {product.Name}\t\t\t {product.Status}");
                }
            }
        }
        public void AddToCart()
        {
            ListProductsInStock();
            Console.Write($"\nListeye eklemek istediğiniz ürünün id'sini seçin: ");
            int Select = int.Parse(Console.ReadLine());
            Product SelectProduct = null;
            foreach (Product product in _products)
            {
                if ((product.Id == Select) && !(product.Stock == 0))
                {
                    SelectProduct = product;
                    _cart.Add(SelectProduct);
                }
            }
            if (SelectProduct == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Listede böyle bir ürün yok veya tükendi.");
                Console.ResetColor();
                Thread.Sleep(1000);
                AddToCart();
            }
            ShowMenu();
        }
        public void ViewCart()
        {
            Console.Clear();
            Console.WriteLine("Sepetinizdeki ürünler: ");
            double TotalPrice = 0;
            int CartSort = 0;
            foreach (Product inCart in _cart)
            {
                CartSort++;
                Console.WriteLine($"{CartSort}\tİsim: {inCart.Name}\t Fiyat: {inCart.Price}");
                TotalPrice += inCart.Price;
            }
            Console.WriteLine($"Toplam ödenecek tutar: {TotalPrice}");
            Console.WriteLine("1 - Siparişi Onayla\t2 - Sepetten Ürün Sil");
            string Select = Console.ReadLine();
            switch(Select)
            {
                case "1":
                    OrderProducts();
                    break;
                case "2":
                    Console.Write("Lütfen silme istediğiniz ürün seçin: ");
                    int SelectToRemove = int.Parse(Console.ReadLine());
                    RemoveFromCart(SelectToRemove);
                    break;
            }
        }
        public void RemoveFromCart(int selectToRemove)
        {
            int CartSort = 0;
            Product productToRemove = null;
            foreach (Product product in _cart)
            {
                CartSort++;
                if (CartSort == selectToRemove)
                    productToRemove = product;

            }
            if (productToRemove != null)
            {
                _cart.Remove(productToRemove);
                ShowMenu();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sepette böyle bir ürün yok. Menüye dönülüyor.");
                Console.ResetColor();
                Thread.Sleep(1000);
                ShowMenu();
            }
        }
        public void OrderProducts()
        {
            Console.Clear();
            Console.WriteLine("Ürünleriniz hazırlanıp kargoya teslim edilecek.");
            _cart.Clear();
            Thread.Sleep(2000);
            ShowMenu();
        }
    }
}
