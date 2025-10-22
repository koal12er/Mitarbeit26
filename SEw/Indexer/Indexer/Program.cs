using Indexer;

// Neues Formel1Piloten-Objekt anlegen
Formel1Piloten f1 = new Formel1Piloten();

// Ein paar Piloten hinzufügen (über den int-Indexer)
f1[1] = new Person { FirstName = "Max", LastName = "Verstappen" };
f1[2] = new Person { FirstName = "Charles", LastName = "Leclerc" };
f1[3] = new Person { FirstName = "Lando", LastName = "Norris" };

// Zugriff über Index (1-basiert)
Console.WriteLine("1. Pilot: " + f1[1]);
Console.WriteLine("------------------------------------");

// Zugriff über String (vollständiger Name)
Console.WriteLine("Suche nach 'Charles Leclerc': " + f1["Charles Leclerc"]);
Console.WriteLine("Suche nach 'Lando Norris': " + f1["Lando Norris"]);
Console.WriteLine("------------------------------------");

// Versuch, jemanden zu finden, der noch nicht existiert
var unknown = f1["Lewis Hamilton"];
if (unknown == null)
    Console.WriteLine("Lewis Hamilton wurde nicht gefunden 😅");
else
    Console.WriteLine("Lewis Hamilton wurde gefunden ");

// Neuen Piloten hinzufügen (über String-Indexer)
f1["Lewis Hamilton"] = new Person { FirstName = "Lewis", LastName = "Hamilton" };
Console.WriteLine("------------------------------------");

// Jetzt nochmal versuchen, Lewis Hamilton zu finden
var unknown1 = f1["Lewis Hamilton"];
if (unknown1 == null)
    Console.WriteLine("Lewis Hamilton wurde nicht gefunden 😅");
else
    Console.WriteLine("Lewis Hamilton wurde gefunden ");

Console.WriteLine("------------------------------------");

// Ganze Liste aller Piloten ausgeben
Console.WriteLine(f1);
Console.WriteLine("------------------------------------");

// Alle vorhandenen Piloten per Schleife (Index) ausgeben
for (int b = 0; b < 99; b++)
{
    if (f1[b] != null)
    {
        Console.WriteLine($"{b}: {f1[b]}");
    }
}

// Alle Piloten per foreach-Schleife (da IEnumerable implementiert)
foreach (var person in f1)
{
    if (person != null)
        Console.WriteLine(person);
}