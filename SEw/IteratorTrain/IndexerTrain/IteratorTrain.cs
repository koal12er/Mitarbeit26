using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorTrain
{
    public class IteratorTrain : IEnumerator<Wagon>
    {
        private Train _train;
        private Wagon? _current;

        public IteratorTrain(Train train)
        {
            _train = train;
            _current = null;
        }

        // Aktuelles Element
        public Wagon Current => _current!;

        object IEnumerator.Current => Current;

        // 🔹 Startet wieder von vorn
        public void Reset()
        {
            _current = null;
        }

        // 🔹 Geht zum nächsten Wagon
        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = _train.first;
            }
            else
            {
                _current = _current.Next;
            }

            return _current != null;
        }

        // Braucht man fast nie wirklich, aber Pflicht
        public void Dispose()
        {
        }
    }
}

