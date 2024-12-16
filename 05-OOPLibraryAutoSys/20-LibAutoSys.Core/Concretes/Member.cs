using _20_LibAutoSys.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Core.Concretes
{
    public class Member : IMember
    {
        // Fields
        private static readonly TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
        private IList<BaseBook> _borrowedBooks;
        private static int _idCounter = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _birthYear;

        // Constructor
        public Member(string firstName, string lastName)
        {
            _id = ++_idCounter;
            _borrowedBooks = new List<BaseBook>();
            FirstName = firstName;
            LastName = lastName;
        }

        // Properties
        public IList<BaseBook> BorrowedBooks
        {
            get { return _borrowedBooks; }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string FirstName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Üye ismi boş olamaz!");
                _firstName = textInfo.ToTitleCase(value.ToLower());
            }
        }
        public string LastName 
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Üye soyismi boş olamaz!");
                _lastName = textInfo.ToTitleCase(value.ToLower());
            } 
        }
        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }
        public int BirthYear
        {
            get
            {
                return _birthYear;
            }
            set
            {
                if ((DateTime.Now.Year - value) < 15)
                    throw new ArgumentException("15 yaş altı üye olamaz!");
                _birthYear = value;
            }
        }

        // Override Method
        public override string ToString()
        {
            return $"ID: {_id}, Name {FullName}";
        }

        // Methods
        public void Borrow(BaseBook book)
        {
            _borrowedBooks.Add(book);
            book.Status = EnumStatus.Borrowed;
        }
        public void Return(BaseBook book)
        {
            _borrowedBooks.Remove(book);
            book.Status = EnumStatus.Available;
        }
    }
}
