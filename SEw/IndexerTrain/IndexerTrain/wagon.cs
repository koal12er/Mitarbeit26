using System.Text;

namespace IteratorTrain;

public class Train
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

    
}

public class Wagon
{
    public int Capacity { get; set; }
    public string Color { get; set; }
    public Wagon  Next { get; set; }
    
    override public string ToString()
    {
        return $"{Capacity}Seats, {Color}";
    }
}