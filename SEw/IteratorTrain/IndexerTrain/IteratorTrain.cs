using System.Collections;
using System.Collections.Generic;

namespace IteratorTrain
{
    // Iterator, der durch die Wagons eines Train-Objekts geht
    public class IteratorTrain : IEnumerator<Wagon>
    {
        private Train _train;        // Referenz auf den Zug
        private Wagon? _current;     // Aktuell betrachteter Wagon
        private bool _started = false; // Merkt, ob der Iterator gestartet wurde

        // Konstruktor bekommt den Zug, über den iteriert werden soll
        public IteratorTrain(Train train)
        {
            _train = train;
            _current = null;
        }

        // Gibt den aktuellen Wagon zurück
        public Wagon Current => _current!;

        // Nicht-generische Version (für Kompatibilität)
        object IEnumerator.Current => Current;

        // Wechselt zum nächsten Wagon
        public bool MoveNext()
        {
            if (!_started)
            {
                _current = _train.First; // Beim ersten Aufruf beim ersten Wagon starten
                _started = true;
            }
            else
            {
                _current = _current?.Next; // Danach zum nächsten Wagon springen
            }

            return _current != null; // Solange es noch Wagons gibt, weitermachen
        }

        // Setzt den Iterator zurück
        public void Reset()
        {
            _current = null;
            _started = false;
        }

        // Wird nicht verwendet, aber vom Interface verlangt
        public void Dispose() { }
    }
}