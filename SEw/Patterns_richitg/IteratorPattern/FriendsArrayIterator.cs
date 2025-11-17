using System.Collections;

namespace IteratorPattern;

public class FriendsArrayIterator : IEnumerator
{
    public Person[] persons {get; init;}
    private int pos = -1;

    public bool MoveNext()
    {
        return ++pos < persons.Length;
    }

    public void Reset()
    {
        pos = -1;
    }
    
    public object? Current => persons[pos];
}