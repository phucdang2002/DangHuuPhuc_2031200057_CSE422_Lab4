using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangHuuPhuc_2031200057_CSE422_Lab4.Repository
{
    interface IReader
    {
        bool BorrowBook(IBook book);
        void ReturnBook(IBook book);
    }
}
