using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Abstract
{
    public interface ISellerService
    {
        public void ListAllProducts(bool showMenuMessage = true);
        public void AddProduct();
        public void DeleteProduct();
        public void UpdateProduct();
    }
}
