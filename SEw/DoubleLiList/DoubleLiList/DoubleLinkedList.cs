namespace DoubleLiList;

/// <summary>
/// Double Linked List - Generic Implementation
/// Unterstützt jeden Datentyp durch Generics
/// </summary>
/// <typeparam name="T">Beliebiger Datentyp (int, string, Person, etc.)</typeparam>
public class DoubleLinkedList<T> : IEnumerable<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }
    public int Count { get; private set; }

    public DoubleLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Element am Anfang einfügen - O(1)
    /// </summary>
    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
        Count++;
    }

    /// <summary>
    /// Element am Ende einfügen - O(1)
    /// </summary>
    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }

    /// <summary>
    /// Ersten Node entfernen - O(1)
    /// </summary>
    public bool RemoveFirst()
    {
        if (Head == null) return false;

        if (Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = Head.Next;
            Head.Previous = null;
        }
        Count--;
        return true;
    }

    /// <summary>
    /// Letzten Node entfernen - O(1)
    /// </summary>
    public bool RemoveLast()
    {
        if (Tail == null) return false;

        if (Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Tail = Tail.Previous;
            Tail.Next = null;
        }
        Count--;
        return true;
    }

    /// <summary>
    /// Bestimmten Wert entfernen - O(n)
    /// </summary>
    public bool Remove(T data)
    {
        Node<T>? current = Head;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
            {
                if (current == Head)
                {
                    return RemoveFirst();
                }
                else if (current == Tail)
                {
                    return RemoveLast();
                }
                else
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return true;
                }
            }
            current = current.Next;
        }
        return false;
    }

    /// <summary>
    /// Wert suchen - O(n)
    /// </summary>
    public Node<T>? Find(T data)
    {
        Node<T>? current = Head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    /// <summary>
    /// Liste leeren - O(1)
    /// </summary>
    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Prüft ob Element vorhanden ist - O(n)
    /// </summary>
    public bool Contains(T data)
    {
        return Find(data) != null;
    }

    /// <summary>
    /// IEnumerable implementieren für foreach
    /// </summary>
    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = Head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Liste als String ausgeben für Debugging
    /// </summary>
    public void Print()
    {
        Node<T>? current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
    
    /// <summary>
    /// Rückwärts ausgeben
    /// </summary>
    public void PrintReverse()
    {
        Node<T>? current = Tail;
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Previous;
        }
        Console.WriteLine("null");
    }
}
