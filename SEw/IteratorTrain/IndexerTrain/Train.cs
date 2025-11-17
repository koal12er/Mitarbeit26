using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorTrain
{
    // Repräsentiert einen Zug, der aus verketteten Wagons besteht
    public class Train : IEnumerable<Wagon>
    {
        public Wagon? First; // Erster Wagon im Zug (Kopf der verketteten Liste)

        // Fügt einen neuen Wagon vorne an den Zug an
        public void Add(Wagon w)
        {
            w.Next = First; // Der neue Wagon zeigt auf den bisherigen ersten
            First = w;      // Und wird selbst der neue erste Wagon
        }

        // Gibt eine Textdarstellung des gesamten Zuges zurück
        public override string ToString()
        {
            var sb = new StringBuilder();
            var temp = First;

            // Geht alle Wagons durch und hängt ihre Namen an
            while (temp != null)
            {
                sb.AppendLine(temp.ToString());
                temp = temp.Next;
            }

            return sb.ToString();
        }

        // Gibt den Iterator für foreach zurück
        public IEnumerator<Wagon> GetEnumerator()
        {
            return new IteratorTrain(this);
        }
        
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}