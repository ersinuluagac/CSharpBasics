using _20_LibAutoSys.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Core.Concretes
{
    public class BookScience : BaseBook
    {
        // Constructor
        public BookScience(int isbn, string title, string authorFirstName, string authorLastName, int publicationYear) : base(isbn, title, authorFirstName, authorLastName, publicationYear)
        {
            Category = "Science";
        }

        // Properties
        public string Category
        {
            get { return base.Category; }
            set { base.Category = value; }
        }
    }
}
