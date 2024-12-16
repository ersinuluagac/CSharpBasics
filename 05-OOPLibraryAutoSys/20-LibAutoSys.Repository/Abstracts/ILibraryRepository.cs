using _20_LibAutoSys.Core.Abstracts;
using _20_LibAutoSys.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Repository.Abstracts
{
    public interface ILibraryRepository<T> where T : IBaseLibrary
    {
        // Book
        void AddBook(BaseBook book);
        void RemoveBook(BaseBook book);
        IList<BaseBook> GetAllBooks();
        IList<BaseBook> GetBooksByMember(Member member);

        // Member
        void AddMember(Member member);
        void RemoveMember(Member member);
        IList<Member> GetAllMembers();
    }
}
