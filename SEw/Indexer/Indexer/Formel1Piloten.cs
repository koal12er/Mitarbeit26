using System.Collections;
using System.Text;

namespace Indexer;

// Klasse verwaltet bis zu 99 Formel-1-Piloten
public class Formel1Piloten : IEnumerable
{
    private const int MAX_PILOTS = 99;          // Maximale Anzahl an Piloten
    private Person[] _piloten = new Person[MAX_PILOTS]; // internes Array

    // Indexer für Zugriff über Zahl (1-basiert!)
    public Person this[int i]
    {
        get { return _piloten[i - 1]; }         // gibt Pilot an Position zurück
        set { _piloten[i - 1] = value; }        // setzt Pilot an Position
    }

    // Indexer für Zugriff über String (vollständiger Name)
    public Person this[string s]
    {
        get
        {
            // Durchsucht alle Piloten nach passendem Namen
            for (int i = 0; i < MAX_PILOTS; i++)
            {
                if (_piloten[i] != null && _piloten[i].ToString() == s)
                    return _piloten[i];          // Treffer gefunden
            }
            return null;                         // Kein Treffer
        }
        set
        {
            // Fügt neuen Piloten an erster freien Stelle ein
            for (int i = 0; i < MAX_PILOTS; i++)
            {
                if (_piloten[i] == null)
                {
                    _piloten[i] = value;
                    return;
                }
            }
        }
    }

    // Gibt alle Piloten als Textliste aus
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < MAX_PILOTS; i++)
        {
            sb.Append($"{i + 1}. {_piloten[i]}\n");
        }
        return sb.ToString();
    }

    // Ermöglicht foreach-Schleifen über die Klasse
    public IEnumerator GetEnumerator()
    {
        return _piloten.GetEnumerator();
    }
}