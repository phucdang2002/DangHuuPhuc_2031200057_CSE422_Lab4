using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DangHuuPhuc_2031200057_CSE422_Lab4.Repository;

namespace DangHuuPhuc_2031200057_CSE422_Lab4.Entity
{
    class Library : ILibrary
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book) => books.Add(book);

        public List<IBook> SearchBook(string title) => books.FindAll(book => book.GetTitle().Contains(title));

        public bool LendBook(IReader reader, IBook book) => reader.BorrowBook(book);

        public void ReturnBook(IReader reader, IBook book) => reader.ReturnBook(book);
    }
}
