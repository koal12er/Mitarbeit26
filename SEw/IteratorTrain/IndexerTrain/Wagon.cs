namespace IteratorTrain;

public class Wagon
{
    public string Color { get; set; }
    public int Capacity { get; set; }
    public Wagon? Next;

 

    public override string ToString() => Color;
}