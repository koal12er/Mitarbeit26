namespace FactoryMethodPattern;

//Produkt
public class Mahlzeit
{
    
}

public class Pizza : Mahlzeit
{
    public Pizza()
    {
        Console.WriteLine("Pizza gebacken");
    }
}

public class Kebab : Mahlzeit
{
    public Kebab(string beilage)
    {
        Console.WriteLine("Kebab fertig, mit " + beilage);
    }
}

public class Kuchen : Mahlzeit
{
    public Kuchen(string kuchenart)
    {
        Console.WriteLine(kuchenart + " ist fertig");
    }
}

public class Waffeln : Mahlzeit
{
    public Waffeln(string toppings)
    {
        Console.WriteLine("Waffeln mit " + toppings + " ist fertig");
    }
}