using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Abstract
{
    public interface ICustomerService
    {
        public void ListProductsInStock();
        public void AddToCart();
        public void ViewCart();
        public void RemoveFromCart(int ToRemove);
        public void OrderProducts();
    }
}
