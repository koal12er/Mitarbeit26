namespace AktienObserverPattern;

public abstract class Aktie
{
    protected List<Investor> myAktie = new ();

    public abstract void Register(Investor i);

    public virtual void Unregister(Investor i)
    {
        myAktie.Remove(i);
    }
    public abstract void Notify(Investor i);

    public abstract int GetCurrent();
}