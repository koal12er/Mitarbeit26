

using Indexer;
// Neues Formel1Piloten-Objekt
Formel1Piloten f1 = new Formel1Piloten();

// Ein paar Piloten hinzufügen
f1[1] = new Person { FirstName = "Max", LastName = "Verstappen" };
f1[2] = new Person { FirstName = "Charles", LastName = "Leclerc" };
f1[3] = new Person { FirstName = "Lando", LastName = "Norris" };

// Zugriff über Index
Console.WriteLine("1. Pilot: " + f1[1]);

// Zugriff über String (Name)
Console.WriteLine("Suche nach 'Charles Leclerc': " + f1["Charles Leclerc"]);
Console.WriteLine("Suche nach 'Lando Norris': " + f1["Lando Norris"]);


f1["Lewis Hamilton"] = new Person { FirstName = "Lewis", LastName = "Hamilton" };    

// Versuch, jemanden zu finden, der nicht existiert
var unknown = f1["Lewis Hamilton"];
if (unknown == null)
    Console.WriteLine("Lewis Hamilton wurde nicht gefunden 😅");
else
{
    Console.WriteLine("Lewis Hamilton wurde  gefunden ");
}



