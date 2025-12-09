namespace DoubleLiList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Double Linked List mit Generics ===\n");

        // Beispiel 1: Liste mit Integers
        Console.WriteLine("--- Integer Liste ---");
        var intList = new DoubleLinkedList<int>();
        intList.AddLast(10);
        intList.AddLast(20);
        intList.AddLast(30);
        intList.AddFirst(5);
        
        Console.Write("Vorwärts: ");
        intList.Print();
        Console.Write("Rückwärts: ");
        intList.PrintReverse();
        Console.WriteLine($"Count: {intList.Count}\n");

        // Beispiel 2: Liste mit Strings
        Console.WriteLine("--- String Liste ---");
        var stringList = new DoubleLinkedList<string>();
        stringList.AddLast("Hallo");
        stringList.AddLast("Welt");
        stringList.AddFirst("Servus");
        
        Console.Write("String Liste: ");
        stringList.Print();
        
        stringList.Remove("Welt");
        Console.Write("Nach Remove('Welt'): ");
        stringList.Print();
        Console.WriteLine();

        // Beispiel 3: Liste mit eigenen Objekten (Person)
        Console.WriteLine("--- Person Liste (Custom Objects) ---");
        var personList = new DoubleLinkedList<Person>();
        personList.AddLast(new Person("Franz", 25));
        personList.AddLast(new Person("Susi", 30));
        personList.AddLast(new Person("Hans", 22));
        
        Console.Write("Personen: ");
        personList.Print();
        
        // Suchen
        var susi = personList.Find(new Person("Susi", 30));
        Console.WriteLine($"Gefunden: {susi?.Data}\n");

        // Beispiel 4: Foreach über Generic Liste
        Console.WriteLine("--- Foreach Beispiel ---");
        Console.WriteLine("Alle Personen:");
        foreach (var person in personList)
        {
            Console.WriteLine($"  - {person}");
        }
        
        Console.WriteLine("\n--- Operationen ---");
        Console.WriteLine($"Contains 'Hans': {personList.Contains(new Person("Hans", 22))}");
        Console.WriteLine($"Count: {personList.Count}");
        
        personList.RemoveFirst();
        Console.Write("Nach RemoveFirst: ");
        personList.Print();
        
        personList.Clear();
        Console.WriteLine($"Nach Clear - Count: {personList.Count}");
    }
}
