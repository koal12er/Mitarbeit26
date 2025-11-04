namespace AktienObserverPattern;

public class Apple:Aktie
{
    static Random rnd = new();
    
    private int currentState = 0;

    public override void Register(Investor i)
    {
        myAktie.Add(i);
        (i as AppleInvestor).myApple = this;
    }

    public void Change()
    {
        currentState = rnd.Next(100, 300);
        foreach (var person in myAktie)
        {
            person.Update();
        }
    }

    public override void Notify(Investor i)
    {
        i.Update();
    }

    public override int GetCurrent()
    {
        return currentState;
    }
}