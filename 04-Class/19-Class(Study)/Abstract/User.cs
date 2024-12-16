using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Abstract
{
    public abstract class User
    {
        // Constructor
        public User(string email)
        {

        }

        // Properties
        public string Email { get; set; }

        //Abstract Method
        public abstract void ShowMenu();
    }
}
