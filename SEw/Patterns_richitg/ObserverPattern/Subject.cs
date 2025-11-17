namespace ObserverPattern;

public abstract class Subject
{
    protected List<Observer> myObservers = new ();

    public abstract void Register(Observer o);

    public virtual void Unregister(Observer o)
    {
        myObservers.Remove(o);
    }
    public abstract void Notify(Observer o);

    public abstract State GetCurrent();
}