using _20_LibAutoSys.Core.Abstracts;
using _20_LibAutoSys.Core.Concretes;
using _20_LibAutoSys.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Repository.Concretes
{
    public class LibraryRepository<T> : ILibraryRepository<T> where T : IBaseLibrary
    {
        // DB List
        private readonly IList<BaseBook> _books;
        private readonly IList<Member> _members;

        // Constructor
        public LibraryRepository()
        {
            _books = new List<BaseBook>();
            _members = new List<Member>();
        }

        // Books
        public void AddBook(BaseBook book)
        {
            _books.Add(book);
        }
        public void RemoveBook(BaseBook book)
        {
            _books.Remove(book);
        }
        public IList<BaseBook> GetAllBooks()
        {
            if (_books == null)
                throw new ArgumentException("Kitap listesi boş!");
            return _books;
        }
        public IList<BaseBook> GetBooksByMember(Member member)
        {
            foreach (var m in _members)
            {
                if (m.Id == member.Id)
                    return m.BorrowedBooks;
            }
            throw new ArgumentException("Böyle bir üye yok!");
        }

        // Member
        public void AddMember(Member member)
        {
            _members.Add(member);
        }
        public void RemoveMember(Member member)
        {
            _members.Remove(member);
        }
        public IList<Member> GetAllMembers()
        {
            if (_members == null)
                throw new ArgumentException("Üye listesi boş!");
            return _members;
        }
    }
}
