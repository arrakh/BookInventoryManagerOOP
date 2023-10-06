namespace BookstoreInventorySystem;

public class Book
{
    private string title;
    private string author;
    private Genre genre;
    private int price;

    public Book(string title, string author, Genre genre, int price)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.price = price;
    }

    public string Title => title;
    public string Author => author;
    public Genre Genre => genre;
    public int Price => price;
}