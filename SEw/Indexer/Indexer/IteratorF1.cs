using System.Collections;

namespace Indexer;

// eigener Enumerator für die Formel1Piloten-Klasse
public class Formel1PilotenEnumerator : IEnumerator
{
    private Person[] _piloten; // Referenz auf das Array aus der Hauptklasse
    private int _position = -1; // Startposition (vor dem ersten Element)

    public Formel1PilotenEnumerator(Person[] piloten)
    {
        _piloten = piloten;
    }

    // Aktuelles Element zurückgeben
    public object Current
    {
        get { return _piloten[_position]; }
    }

    // Einen Schritt weiter gehen
    public bool MoveNext()
    {
        _position++;
        // Überspringt null-Einträge, wenn du magst
        while (_position < _piloten.Length && _piloten[_position] == null)
            _position++;
        
        return _position < _piloten.Length;
    }

    // Position zurücksetzen (auf Anfang)
    public void Reset()
    {
        _position = -1;
    }
}