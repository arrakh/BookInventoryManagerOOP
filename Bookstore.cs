using BookstoreInventorySystem.Roles;

namespace BookstoreInventorySystem;

public class Bookstore
{
    private List<Employee> employees = new();
    private List<Book> books = new ();
    private Dictionary<Genre, List<Book>> booksByGenre = new ();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    
    public void AddBook(Book book)
    {
        books.Add(book);

        if (!booksByGenre.TryGetValue(book.Genre, out var list))
        {
            list = new List<Book>();
            booksByGenre[book.Genre] = list;
        }
        
        list.Add(book);
    }

    public void PrintGenres()
    {
        Console.WriteLine("===================");
        Console.WriteLine("Book Count by Genres:");

        foreach (var pair in booksByGenre)
            Console.WriteLine($"- {pair.Key}: {pair.Value.Count}"); 
    }

    public void PrintInventoryManagers()
    {
        Console.WriteLine("===================");
        Console.WriteLine($"Employee List ({employees.Count}):");
        foreach (var employee in employees)
        {
            Console.WriteLine($"- {employee.Name}: {employee.GetType().Name}");
            if (employee is not InventoryManager im) continue;

            string genres = String.Join(", ", im.Genres);
            
            Console.WriteLine("    > Responsible Genres: " + genres);
        }
    }

    public void PrintInventoryManagerTotalValues()
    {
        Console.WriteLine("===================");
        Console.WriteLine("Inventory Manager Total Values:");

        foreach (var employee in employees)
        {
            if (employee is not InventoryManager im) continue;

            Console.WriteLine($"- {employee.Name}:");
            int totalPrice = 0;
            string bookList = String.Empty;

            foreach (var genre in im.Genres)
            {
                if (!booksByGenre.TryGetValue(genre, out var list)) continue;
                foreach (var book in list)
                {
                    totalPrice += book.Price;
                    bookList += $"    > [{book.Genre}] {book.Title}, by {book.Author} (${book.Price})\n";
                }
            }
            
            Console.WriteLine($"Total Book Value: ${totalPrice}");
            Console.WriteLine(bookList);
        }
    }
}