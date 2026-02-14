namespace GlobalLogistics.Core.Models;

public abstract class Person
{
    public Guid Id { get; init; }
    private string? _name;

    public string Name
    {
        get => _name!;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public Person()
    {
        Id = Guid.NewGuid(); // Generates a unique ID
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"My name is {Name}, ID: {Id}");
    }
}