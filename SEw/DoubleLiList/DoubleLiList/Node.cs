namespace DoubleLiList;

/// <summary>
/// Node für die Double Linked List - Generic Typ T
/// </summary>
/// <typeparam name="T">Beliebiger Datentyp</typeparam>
public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }
    public Node<T>? Previous { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}
