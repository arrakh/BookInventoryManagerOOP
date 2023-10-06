namespace BookstoreInventorySystem.Roles;

public class InventoryManager : Employee
{
    private HashSet<Genre> genres = new();

    public InventoryManager(string name, params Genre[] responsibleGenres) : base(name)
    {
        foreach (var genre in responsibleGenres)
        {
            Genres.Add(genre);
        }
    }

    public HashSet<Genre> Genres => genres;
}