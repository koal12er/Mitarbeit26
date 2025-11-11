using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorTrain
{
    public class Train : IEnumerable<Wagon>
    {
        public Wagon? First;

        public void Add(Wagon w)
        {
            w.Next = First;
            First = w;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var temp = First;
            while (temp != null)
            {
                sb.AppendLine(temp.ToString());
                temp = temp.Next;
            }
            return sb.ToString();
        }

        // Iterator verwenden
        public IEnumerator<Wagon> GetEnumerator()
        {
            return new IteratorTrain(this);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}