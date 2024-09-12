using EFCoreHomeworkGokceSporAlagoz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomeworkGokceSporAlagoz.AbstractServices
{
    public interface IAuthorCrud
    {
        void AddAuthor(Author author);
        void GetAllAuthors();
        void UpdateAuthor(int id, Author author);
        void DeleteAuthor(int id);
    }
}
