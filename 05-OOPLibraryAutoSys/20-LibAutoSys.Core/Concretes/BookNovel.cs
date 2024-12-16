using _20_LibAutoSys.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Core.Concretes
{
    public class BookNovel : BaseBook
    {
        // Constructor
        public BookNovel(int isbn, string title, string authorFirstName, string authorLastName, int publicationYear) : base(isbn, title, authorFirstName, authorLastName, publicationYear)
        {
            Category = "Novel";
        }

        // Properties
        public string Category
        {
            get { return base.Category; }
            set { base.Category = value; }
        }
    }
}
