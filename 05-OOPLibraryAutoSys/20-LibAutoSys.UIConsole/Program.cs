using _20_LibAutoSys.Core.Abstracts;
using _20_LibAutoSys.Core.Concretes;
using _20_LibAutoSys.Repository.Abstracts;
using _20_LibAutoSys.Repository.Concretes;
using _20_LibAutoSys.Service.Abstracts;
using _20_LibAutoSys.Service.Concretes;

namespace _20_LibAutoSys.UIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member("Recep Ersin", "Uluağaç");
            Member member2 = new Member("Yağız", "Gökmen");

            BaseBook book1 = new BookHistory(1234, "Romalılar", "Reginald", "Barrow", 1986);
            BaseBook book2 = new BookNovel(3456, "Tatar Çölü", "Dino", "Buzatti", 2002);
            BaseBook book3 = new BookScience(5678, "Kozmos", "Carl", "Sagan", 1999);

            ILibraryRepository<IBaseLibrary> libraryRepo = new LibraryRepository<IBaseLibrary>();
            ILibraryService libraryService = new LibraryService();

            libraryRepo.AddMember(member1);
            libraryRepo.AddMember(member2);
            libraryRepo.AddBook(book1);
            libraryRepo.AddBook(book2);
            libraryRepo.AddBook(book3);

            libraryService.BorrowBook(book2, member1);

            foreach(var item in libraryRepo.GetAllBooks())
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}
