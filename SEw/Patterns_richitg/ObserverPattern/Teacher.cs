namespace ObserverPattern;

public enum State{SEW,INSY,FREE}

public class Teacher:Subject
{
    State currentState = State.INSY;


    public override void Register(Observer o)
    {
        myObservers.Add(o);
        (o as Student).myTeacher = this;
    }

    public void Teach(State state)
    {
        currentState = state;
        foreach (var student in myObservers)
        {
            student.Update();
        }
    }
    
    public override void Notify(Observer o)
    {
        o.Update();
    }

    public override State GetCurrent()
    {
        return currentState;
    }
}