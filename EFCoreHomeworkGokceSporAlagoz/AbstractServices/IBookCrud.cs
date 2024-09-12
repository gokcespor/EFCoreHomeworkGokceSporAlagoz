using EFCoreHomeworkGokceSporAlagoz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomeworkGokceSporAlagoz.AbstractServices
{
    public interface IBookCrud
    {
        void AddBook(Book book);
        void GetAllBooks();
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}
