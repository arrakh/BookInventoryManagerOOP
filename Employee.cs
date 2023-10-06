namespace BookstoreInventorySystem;

public abstract class Employee
{
    protected string name;

    protected Employee(string name)
    {
        this.name = name;
    }

    public string Name => name;
}