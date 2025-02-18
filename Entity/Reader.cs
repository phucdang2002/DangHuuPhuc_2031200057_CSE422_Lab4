using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DangHuuPhuc_2031200057_CSE422_Lab4.Repository;

namespace DangHuuPhuc_2031200057_CSE422_Lab4.Entity
{
    internal class Reader:IReader
    {
        private int Id { get; }
        private string Name { get; }
        private List<IBook> BorrowedBooks = new List<IBook>();

        public Reader(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public bool BorrowBook(IBook book)
        {
            if (BorrowedBooks.Count < 3 && book.GetQuantity() > 0)
            {
                book.UpdateQuantity(book.GetQuantity()-1);
                if (book.GetQuantity() == 0)
                    book.UpdateStatus(BookStatus.Borrowed);
                BorrowedBooks.Add(book);
                Console.WriteLine($"Borrowed: {book.GetTitle()}, Status: {book.GetStatus()}");
                return true;
            }
            return false;
        }

        public void ReturnBook(IBook book)
        {
            BorrowedBooks.Remove(book);
            book.UpdateQuantity(book.GetQuantity() + 1);
            book.UpdateStatus(BookStatus.Available);
            Console.WriteLine($"Returned: {book.GetTitle()}, Status: {book.GetStatus()}");
        }
    }
}
