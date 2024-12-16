using _20_LibAutoSys.Core.Abstracts;
using _20_LibAutoSys.Core.Concretes;
using _20_LibAutoSys.Repository.Abstracts;
using _20_LibAutoSys.Repository.Concretes;
using _20_LibAutoSys.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Service.Concretes
{
    public class LibraryService : ILibraryService
    {
        // Repo
        private readonly ILibraryRepository<IBaseLibrary> _libraryRepository;

        // Constructor
        public LibraryService()
        {
            _libraryRepository = new LibraryRepository<IBaseLibrary>();
        }

        // Methods
        public void BorrowBook(BaseBook book, Member member)
        {
            if (book.Status == EnumStatus.Available)
                member.Borrow(book);
            else
                throw new ArgumentException("Kitap ödünçte veya mevcut değil!");
        }

        public void ReturnBook(BaseBook book, Member member)
        {
            if (member.BorrowedBooks.Contains(book))
                member.Return(book);
            else
                throw new ArgumentException("Kitap üyede değil!");
        }
    }
}
