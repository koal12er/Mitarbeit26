using System.Collections;

namespace IteratorPattern;

public class Team : IEnumerable
{
    public Person[] members;
    
    public int NumberOfMembers => members.Length;

    public Team(Person[] members)
    {
        this.members = members;
    }

    public Person this[int index]
    {
        get => members[index];
    }

    public IEnumerator GetEnumerator()
    {
        //return members.GetEnumerator();
        return new FriendsArrayIterator {persons = members};
    }
}