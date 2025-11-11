using System.Collections;
using System.Text;

namespace IteratorTrain;

public class Train: IEnumerable<Wagon>
{
   
    public Wagon first;
    
    

    public void Add(Wagon tooAdd)
    {
        tooAdd.Next = first;
        StringBuilder sb = new StringBuilder();
        
    }

    override public string ToString()
    {
        Wagon temp = first;
        StringBuilder sb = new StringBuilder();
        while(temp!=null){
            sb.Append(temp+"\n");
            temp = temp.Next;
        }
        return sb.ToString();
    }
    
    // 🔹 Hier wird der IteratorTrain verwendet
    public IEnumerator<Wagon> GetEnumerator()
    {
        return new IteratorTrain(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    
}

