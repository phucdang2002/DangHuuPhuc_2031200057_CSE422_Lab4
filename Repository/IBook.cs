using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DangHuuPhuc_2031200057_CSE422_Lab4.Entity;

namespace DangHuuPhuc_2031200057_CSE422_Lab4.Repository
{
    interface IBook
    {
        int GetId();
        string GetTitle();
        string GetAuthor();
        string GetCategory();
        int GetQuantity();
        void UpdateQuantity(int qty);
        BookStatus GetStatus();
        void UpdateStatus(BookStatus status);
    }
}
