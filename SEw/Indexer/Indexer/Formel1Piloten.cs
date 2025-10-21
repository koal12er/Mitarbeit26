namespace Indexer;

public class Formel1Piloten
{
    private const int MAX_PILOTS = 99;
    Person[] _piloten = new Person[MAX_PILOTS];

    public Person this[int i]
    {
        get{return _piloten[i-1];}
        set{_piloten[i-1]=value;}
    }

    public Person this[string s]
    {
        get
        {
            for (int i = 0; i < MAX_PILOTS; i++)
            {
                if (_piloten[i] != null)
                    if(_piloten[i].ToString()==s)
                        return _piloten[i];
            }
            return null;
        }
    }
        
}