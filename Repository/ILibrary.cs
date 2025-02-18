using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangHuuPhuc_2031200057_CSE422_Lab4.Repository
{
    interface ILibrary
    {
        void AddBook(IBook book);
        List<IBook> SearchBook(string title);
        bool LendBook(IReader reader, IBook book);
        void ReturnBook(IReader reader, IBook book);
    }
}
