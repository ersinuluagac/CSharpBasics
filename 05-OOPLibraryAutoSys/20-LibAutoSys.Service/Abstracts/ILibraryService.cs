using _20_LibAutoSys.Core.Abstracts;
using _20_LibAutoSys.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Service.Abstracts
{
    public interface ILibraryService
    {
        void BorrowBook(BaseBook book, Member member);
        void ReturnBook(BaseBook book, Member member);
    }
}
