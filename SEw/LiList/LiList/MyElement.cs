namespace LiList;

public class MyElement
{
    // Zeiger auf den nächsten Knoten in der Liste
    public MyElement Next { get; set; }

    // Der gespeicherte Wert dieses Knotens
    public int value { get; set; }

    // Gibt die gesamte Liste ab diesem Knoten als String zurück
    // Rekursiv: wenn kein nächster Knoten → nur den Wert ausgeben
    // Wenn ein nächster existiert → "wert>nächsterKnoten"
    public override string ToString()
    {
        return Next == null 
            ? value.ToString() 
            : value + ">" + Next.ToString();
    }
}