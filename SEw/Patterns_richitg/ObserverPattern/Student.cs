namespace ObserverPattern;

public class Student:Observer
{
    public Teacher myTeacher;
    
    public string Name { get; init; }
    public override void Update()
    {
        Console.WriteLine(Name + ":" + myTeacher.GetCurrent());
    }
}