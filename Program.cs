// See https://aka.ms/new-console-template for more information

using BookstoreInventorySystem;

Bookstore bookstore = new Bookstore();

var books = RandomGenerator.GenerateBooks(100, 20, 200);
foreach(var book in books) bookstore.AddBook(book);

var employees = RandomGenerator.GenerateEmployees(10);
foreach(var employee in employees) bookstore.AddEmployee(employee);

bookstore.PrintGenres();
bookstore.PrintInventoryManagers();
bookstore.PrintInventoryManagerTotalValues();