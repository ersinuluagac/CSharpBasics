using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LibAutoSys.Core.Abstracts
{
    public interface IMember : IBaseLibrary
    {
        // Properties
        public IList<BaseBook> BorrowedBooks { get; }
        public int Id { get; }
        public string FirstName { set; }
        public string LastName { set; }
        public string FullName { get; }

        // Methods
        void Borrow(BaseBook book);
        void Return(BaseBook book);
    }
}
