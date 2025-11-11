using System.Collections;
using System.Collections.Generic;

namespace IteratorTrain
{
    // Iterator, der über die Wagons eines Train-Objekts läuft
    public class IteratorTrain : IEnumerator<Wagon>
    {
        private Train _train;         // der Zug, über den iteriert wird
        private Wagon? _current;      // aktueller Wagon
        private bool _started = false;

        public IteratorTrain(Train train)
        {
            _train = train;
            _current = null;
        }

        // gibt den aktuellen Wagon zurück
        public Wagon Current => _current!;

        object IEnumerator.Current => Current;

        // springt zum nächsten Wagon
        public bool MoveNext()
        {
            if (!_started)
            {
                _current = _train.First;
                _started = true;
            }
            else
            {
                _current = _current?.Next;
            }

            return _current != null;
        }

        // setzt den Iterator zurück
        public void Reset()
        {
            _current = null;
            _started = false;
        }

        // wird hier nicht gebraucht, aber Pflicht (wegen IDisposable)
        public void Dispose() { }
    }
}