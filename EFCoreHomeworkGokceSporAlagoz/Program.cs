using EFCoreHomeworkGokceSporAlagoz.ConcreteServices;
using EFCoreHomeworkGokceSporAlagoz.Context;
using EFCoreHomeworkGokceSporAlagoz.Entities;

CrudService crudService = new(new AppDbContext());
Author author = new Author();
Book book = new Book();
Category category = new Category();

// Eklemeler

//Console.Write("Yazar ekleyiniz: ");
//author.Name = Console.ReadLine();

//crudService.AddAuthor(author);

// ---------------------------------

Console.Write("Kitap ekleyiniz: ");
book.Title = Console.ReadLine();

crudService.GetAllAuthors();

Console.Write("Listeden yazar Id si seçiniz: ");
book.AuthorId = Convert.ToInt32(Console.ReadLine());

//if (author.Id == book.AuthorId)
//{
    
    
//}

crudService.GetAllCategories();

Console.Write("Listeden kategori Id si seçiniz:  ");
book.CategoryId = Convert.ToInt32(Console.ReadLine());

crudService.AddBook(book);

// ---------------------------------

//Console.Write("Kategori ekleyiniz: ");
//category.CategoryName = Console.ReadLine();

//crudService.AddCategory(category);



// Silmeler

//crudService.DeleteAuthor(author.Id);

// ---------------------------------

//crudService.DeleteBook(book.Id);

// ---------------------------------

//crudService.DeleteCategory(category.Id);



// Getirmeler

//crudService.GetAllAuthors();

// ---------------------------------

//crudService.GetAllBooks();

// ---------------------------------

//crudService.GetAllCategories();



// Güncellemeler

//crudService.UpdateAuthor(author.Id, new Author());

// ---------------------------------

//crudService.UpdateBook();

// ---------------------------------

//crudService.UpdateCategory(category.Id, new Category());
