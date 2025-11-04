namespace AktienObserverPattern;

public class AppleInvestor:Investor
{
    public Apple myApple;
    
    public override void Update()
    {
        Console.WriteLine("Apple Aktie" + ":" + myApple.GetCurrent());
    }
}