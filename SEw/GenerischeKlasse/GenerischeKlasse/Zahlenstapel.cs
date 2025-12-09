namespace GenerischeKlasse;

/// <summary>
/// Generischer Stack - funktioniert mit jedem Datentyp
/// </summary>
/// <typeparam name="T">Beliebiger Datentyp (int, string, Person, etc.)</typeparam>
public class Stapel<T>
{
    private int pos = -1;
    private T[] daten = new T[10];

    /// <summary>
    /// Element auf den Stack legen
    /// </summary>
    public void Push(T item)
    {
        if (pos >= daten.Length - 1) throw new Exception("Stack is full");
        daten[++pos] = item;
    }
    
    /// <summary>
    /// Element vom Stack nehmen
    /// </summary>
    public T Pop()
    {
        if (pos < 0) throw new Exception("Stack is empty");
        return daten[pos--];
    }
    
    /// <summary>
    /// Anzahl der Elemente am Stack
    /// </summary>
    public int Count => pos + 1;
    
    /// <summary>
    /// Ist der Stack leer?
    /// </summary>
    public bool IsEmpty => pos < 0;
    
    /// <summary>
    /// Oberstes Element anschauen ohne zu entfernen
    /// </summary>
    public T Peek()
    {
        if (pos < 0) throw new Exception("Stack is empty");
        return daten[pos];
    }
}