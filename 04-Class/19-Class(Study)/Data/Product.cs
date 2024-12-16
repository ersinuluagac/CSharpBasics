using _19_Class_Study_.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Data
{
    public class Product
    {
        // Fields
        private static int _id = 0;
        private string _name;

        // Constructor
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
            _id++;
            Id = _id;
        }

        // Properties
        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim().Substring(0, 1).ToUpper() + value.Trim().Substring(1).ToLower();
                }
            }
        }
        public double Price { get; set; }
        public int Stock { get; set; }
        public StatusProduct Status
        {
            get
            {
                if (Stock <= 0)
                    return StatusProduct.Tükendi;
                else if (Stock <= 5)
                {
                    return StatusProduct.Tükeniyor;
                }
                else
                    return StatusProduct.Stokta;
            }
        }

        // Override Method
        public override string ToString()
        {
            string priceUSD = Price.ToString("C", new CultureInfo("en-US"));
            if (Stock <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return $"Id: {Id}\t İsim: {Name}\t Fiyat: {priceUSD}\t Stok: {Stock}\t Durum: {Status}";
            }
            else if (Stock <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return $"Id: {Id}\t İsim: {Name}\t Fiyat: {priceUSD}\t Stok: {Stock}\t Durum: {Status}";
            }
            else
            {
                Console.ResetColor();
                return $"Id: {Id}\t İsim: {Name}\t Fiyat: {priceUSD}\t Stok: {Stock}\t Durum: {Status}";
            }
        }
    }
}
