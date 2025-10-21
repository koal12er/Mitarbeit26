using System.Collections;
using System.Text;

namespace Indexer;

public class Formel1Piloten : IEnumerable
{
    private const int MAX_PILOTS = 99;
    private Person[] _piloten = new Person[MAX_PILOTS];


    public Person this[int i]
    {
        get { return _piloten[i - 1]; }
        set { _piloten[i - 1] = value; }
    }


    public Person this[string s]
    {
        get
        {
            for (int i = 0; i < MAX_PILOTS; i++)
            {
                if (_piloten[i] != null && _piloten[i].ToString() == s)
                    return _piloten[i];
            }
            return null;
        }
        set
        {
            
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

    public override string ToString()
    {
        StringBuilder sb = new  StringBuilder();
        for (int i = 0; i < MAX_PILOTS; i++)
        {
            sb.Append($"{i + 1}. {_piloten[i]}\n");
        }
        return sb.ToString();
    }

    public IEnumerator GetEnumerator()
    {
        return _piloten.GetEnumerator();
    }
}