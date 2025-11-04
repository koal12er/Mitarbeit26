using System.Text.Json.Serialization.Metadata;

namespace FactoryMethodPattern;

public abstract class Restaurant
{
    protected virtual void BestellungAufnehmen()
    {
        Console.WriteLine("Ihre Bestellung, bitte!");
    }

    protected virtual void MahlzeitServieren()
    {
        Console.WriteLine("Bitte sehr, ihr Essen ist fertig");
    }

    protected abstract Mahlzeit MahlzeitZubereiten();

    public virtual Mahlzeit MahlzeitLiefern()
    {
        BestellungAufnehmen();
        var m = MahlzeitZubereiten();
        MahlzeitServieren();
        return m;
    }
}


public class Pizzeria : Restaurant
{
    protected override Mahlzeit MahlzeitZubereiten()
    {
        return new Pizza();
    }
}

public class Kebabbude : Restaurant
{
    private string beilage = Console.ReadLine();
    
    protected override void BestellungAufnehmen()
    {
        Console.WriteLine("He Chefe, bist wieder da? Kebab mit " + beilage);
    }
    
    protected override void MahlzeitServieren()
    {
        Console.WriteLine($"Einmal Kebab mit {beilage}. 6 Euro bitte Chefe");
    }
    
    protected override Mahlzeit MahlzeitZubereiten()
    {
        return new Kebab(beilage);
    }
}

public class Cafe : Restaurant
{
    protected override Mahlzeit MahlzeitZubereiten()
    {
        return new Kuchen("Sachertorte");
    }
    
    protected override void MahlzeitServieren()
    {
        Console.WriteLine("Wuensche gut zu speisen");
    }
}

public class Weihnachtsmarkt : Restaurant
{
    protected override Mahlzeit MahlzeitZubereiten()
    {
        return new Waffeln("Schlagobers");
    }
    
    protected override void MahlzeitServieren()
    {
        Console.WriteLine("Bitte sehr");
    }
}