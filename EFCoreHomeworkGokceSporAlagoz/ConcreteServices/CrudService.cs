using EFCoreHomeworkGokceSporAlagoz.AbstractServices;
using EFCoreHomeworkGokceSporAlagoz.Context;
using EFCoreHomeworkGokceSporAlagoz.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomeworkGokceSporAlagoz.ConcreteServices
{
    public class CrudService : IBookCrud, ICategoryCrud, IAuthorCrud
    {
        private readonly AppDbContext _context;

        public CrudService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var listAuthors = _context.Authors.ToList();

            foreach (var item in listAuthors)
            {
                Console.Write($"{item.Id} Id numaralı yazar: {item.Name}\n");
            }
            Console.Write("Lütfen silmek istediğiniz yazarın Id sini yazınız: ");
            id = Convert.ToInt32(Console.ReadLine());

            var author = _context.Authors.FirstOrDefault(x => x.Id == id);

            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            var listBooks = _context.Books.ToList();

            foreach (var item in listBooks)
            {
                Console.WriteLine($"{item.Id} Id sine sahip kitap {item.Title}");
            }

            Console.Write("Lütfen silmek istediğiniz kitabın Od sini giriniz: ");
            id = Convert.ToInt32(Console.ReadLine());
            
            var book = _context.Books.FirstOrDefault(x => x.Id == id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            var listCategories = _context.Categories.ToList();

            foreach (var item in listCategories)
            {
                Console.WriteLine($"{item.Id} Id sine sahip kategori {item.CategoryName}");
            }

            Console.Write("Lütfen silmek istediğiniz kategorinin Id sini seçiniz: ");
            id = Convert.ToInt32(Console.ReadLine());

            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public void GetAllAuthors()
        {
            var listAuthor = _context.Authors.ToList();
            Console.Write("Yazarlar---------------\n");
            foreach (var author in listAuthor)
            {
                Console.Write($"Id si {author.Id} olan yazar {author.Name}");
                Console.WriteLine(" ");
            }
        }

        public void GetAllBooks()
        {
            var listBook = _context.Books.ToList();
            Console.Write("Kitaplar---------------\n");
            foreach (var book in listBook)
            {
                Console.Write(book.Title);
                Console.WriteLine(" ");
            }
        }

        public void GetAllCategories()
        {
            var listCategory = _context.Categories.ToList();
            Console.Write("Kategoriler---------------\n");
            foreach (var category in listCategory)
            {
                Console.Write($"Id si {category.Id} olan kategori {category.CategoryName}");
                Console.WriteLine(" ");
            }
        }

        public void UpdateAuthor(int id, Author author)
        {
            var listAuthors = _context.Authors.ToList();

            foreach (var item in listAuthors)
            {
                Console.Write($"{item.Id} Id disi olan yazar {item.Name}\n");
            }

            Console.Write("Lütfen güncellemek istediğiniz yazarın Id sini seçiniz: ");
            id = Convert.ToInt32(Console.ReadLine());

            author = _context.Authors.FirstOrDefault(x => x.Id == id); 

            if(author != null)
            {
                Console.Write("Lütfen yazar adı giriniz: ");
                author.Name = Console.ReadLine();

                _context.Authors.Update(author);
                _context.SaveChanges();
            }
        }

        public void UpdateBook(int id, Book book)
        {
            var listBooks = _context.Books.ToList();

            foreach (var item in listBooks)
            {
                Console.Write($"{item.Id} Id si olan kitap adı {item.Title}\n");
            }

            Console.Write("Lütfen güncellemek istediğiniz kitabın Id sini giriniz: ");
            id = Convert.ToInt32(Console.ReadLine());

            book = _context.Books.FirstOrDefault(x => x.Id == id);

            if (book != null)
            {
                Console.Write("Lütfen kitap adı giriniz: ");
                book.Title = Console.ReadLine();

                _context.Books.Update(book);
                _context.SaveChanges();
            }

        }

        public void UpdateCategory(int id, Category category)
        {
            var listCategories = _context.Categories.ToList();

            foreach (var item in listCategories)
            {
                Console.Write($"{item.Id} Id si olan kategori {item.CategoryName}\n");
            }

            Console.Write("Lütfen güncellemek istediğiniz kategorinin Id sini giriniz: ");
            id = Convert.ToInt32(Console.ReadLine());

            category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category != null)
            {
                Console.Write("Lütfen kategori adı giriniz: ");
                category.CategoryName = Console.ReadLine();

                _context.Categories.Update(category);
                _context.SaveChanges();
            }
        }
    }
}
