namespace LiList;

public class MyLinkedList
{
    // Referenz auf den ersten Knoten der Liste
    public MyElement Head { get; set; }


    // Fügt ein Element am Beginn der Liste ein
    public void AddFirst(int value)
    {
        // Neuen Knoten erzeugen
        MyElement tmp = new MyElement { value = value };

        // Wenn bereits ein Head existiert → neuen Knoten davorhängen
        if (Head != null)
            tmp.Next = Head;

        // Neuer Knoten wird Head
        Head = tmp;
    }


    // Fügt ein Element am Ende der Liste ein
    public void AddLast(int value)
    {
        // Wenn Kopf leer → neuer Knoten wird Head
        if (Head == null)
            Head = new MyElement { value = value };
        else
        {
            // Sonst bis zum letzten Knoten durchgehen
            MyElement tmp = Head;
            while (tmp.Next != null)
                tmp = tmp.Next;

            // Neuen Knoten hinten anhängen
            tmp.Next = new MyElement { value = value };
        }
    }


    // Entfernt das erste vorkommende Element mit dem angegebenen Wert
    public void Remove(int value)
    {
        // Leere Liste → nichts zu tun
        if (Head == null) return;

        // Fall 1: Der Head selbst soll entfernt werden
        if (Head.value == value)
        {
            Head = Head.Next;   // Head auf den nächsten verschieben
            return;
        }

        // Laufvariablen für das Durchgehen
        MyElement current = Head;   // aktueller Knoten
        MyElement previous = null;  // vorheriger Knoten

        // Liste durchlaufen, bis gesuchter Wert gefunden wird
        while (current != null && current.value != value)
        {
            previous = current;
            current = current.Next;
        }

        // Wenn nichts gefunden → abbrechen
        if (current == null) return;

        // Knoten "überspringen", indem previous.Next auf current.Next gesetzt wird
        previous.Next = current.Next;
    }


    // Gibt eine Text-Darstellung der Liste zurück (aktuell nur Head)
    public override string ToString()
    {
        return Head.ToString(); // Hinweis: Das gibt NICHT die ganze Liste aus
    }
}