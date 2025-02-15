using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangHuuPhuc_2031200057_CSE422_Lab4.Entity
{
    public enum BookStatus
    {
        Available, Borrowed
    }
    public class Book : IBook
    {
        private int Id;
        private string Title;
        private string Author;
        private string Category;
        private int Quantity;
        private BookStatus Status;

        public Book(int id, string title, string author, string category, int quantity)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.Quantity = quantity;
            this.Status = quantity > 0 ? BookStatus.Available : BookStatus.Borrowed;
        }

        public int GetId() => Id;
        public string GetTitle() => Title;
        public string GetAuthor() => Author;
        public string GetCategory() => Category;
        public int GetQuantity() => Quantity;
        public void UpdateQuantity(int qty) => Quantity = qty;
        public BookStatus GetStatus() => Status;
        public void UpdateStatus(BookStatus status) => Status = status;
    }
}