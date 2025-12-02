using LiList;
Console.WriteLine("Hinzufügen der Elemente");
MyLinkedList list = new MyLinkedList();
list.AddFirst(17);
Console.WriteLine(list.count);
list.AddFirst(2);
Console.WriteLine(list.count);
list.AddFirst(33);
Console.WriteLine(list.count);
list.AddFirst(8);
Console.WriteLine(list.count);
Console.WriteLine(list);
Console.WriteLine("Löschen");
list.Remove(33);
Console.WriteLine(list.count);
Console.WriteLine("Ergebnis");
Console.WriteLine(list);
Console.WriteLine(list.count);

// Wir holen uns Referenzen zu bestimmten Elementen
MyElement elementWith8 = list.Head; // Head ist die 8
MyElement elementWith2 = list.Head.Next; // Nächstes ist die 2
MyElement elementWith17 = list.Head.Next.Next.Next.Next.Next; // Übernächstes ist die 17

list.AddAfter(elementWith2, 10);
Console.WriteLine("Nach AddAfter(2, 10):");
Console.WriteLine(list);

list.AddBefore(elementWith17, 20);
Console.WriteLine("Nach AddBefore(17, 20):");
Console.WriteLine(list);

