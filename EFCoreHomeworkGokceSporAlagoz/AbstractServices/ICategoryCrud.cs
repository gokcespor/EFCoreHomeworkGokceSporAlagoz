using EFCoreHomeworkGokceSporAlagoz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomeworkGokceSporAlagoz.AbstractServices
{
    public interface ICategoryCrud
    {
        void AddCategory(Category category);
        void GetAllCategories();
        void UpdateCategory(int id, Category category);
        void DeleteCategory(int id);
    }
}
