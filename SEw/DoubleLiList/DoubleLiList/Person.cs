namespace DoubleLiList;

/// <summary>
/// Beispiel-Klasse um Generics zu demonstrieren
/// </summary>
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} ({Age})";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Person other)
        {
            return Name == other.Name && Age == other.Age;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}
