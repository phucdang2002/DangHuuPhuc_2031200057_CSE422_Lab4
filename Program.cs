using DangHuuPhuc_2031200057_CSE422_Lab4.Entity;

ILibrary library = new Library();
IBook book1 = new Book(1, "Design Patterns", "GoF", "Software", 5);
IBook book2 = new Book(2, "Clean Code", "Robert C. Martin", "Programming", 3);
library.AddBook(book1);
library.AddBook(book2);

IReader reader = new Reader(101, "Alice");
reader.BorrowBook(book1);
reader.ReturnBook(book1);