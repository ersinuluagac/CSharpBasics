using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Core.Abstracts
{
    public class BaseBook : IBaseLibrary
    {
        // Fields
        private static readonly TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
        private int _isbn;
        private string _title;
        private string _authorFirstName;
        private string _authorLastName;
        private string _category;
        private int _publicationYear;

        // Constructor
        public BaseBook(int isbn, string title, string authorFirstName, string authorLastName, int publicationYear)
        {
            Isbn = isbn;
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            PublicationYear = publicationYear;
        }

        // Properties
        public int Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                if (value > 999 && value < 10000)
                {
                    _isbn = value;
                }
                else
                {
                    throw new Exception("ISBN 4 haneli olmalı!");
                }
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Başlık boş olamaz!");
                _title = textInfo.ToTitleCase(value.ToLower());
            }
        }
        public string AuthorFirstName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Yazar ismi boş olamaz!");
                _authorFirstName = textInfo.ToTitleCase(value.ToLower());
            }
        }
        public string AuthorLastName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Yazar soyismi boş olamaz!");
                _authorLastName = textInfo.ToTitleCase(value.ToLower());
            }
        }
        public string AuthorFullName
        {
            get
            {
                return $"{_authorFirstName} {_authorLastName}";
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public int PublicationYear
        {
            get
            {
                return _publicationYear;
            }
            set
            {
                if (value > DateTime.Now.Year)
                    throw new ArgumentException("Yayın yılı gelecekten olamaz!");
                _publicationYear = value;
            }
        }
        public EnumStatus Status { get; set; } = EnumStatus.Available;

        // Override Method
        public override string ToString()
        {
            return $"Title: {Title},\n\tAuthor: {AuthorFullName}, Category: {Category}";
        }
    }
}
