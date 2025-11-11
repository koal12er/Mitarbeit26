using IteratorTrain;

// Erstellen der einzelnen Wagons
Wagon a = new Wagon { Capacity = 48, Color = "Red" };
Wagon b = new Wagon { Capacity = 68, Color = "Green" };
Wagon c = new Wagon { Capacity = 100, Color = "Blue" };

// Erstellen eines neuen Zuges
Train vindobona = new Train();

// Wagons zum Zug hinzufügen (neuer wird vorne angehängt)
vindobona.Add(a);
vindobona.Add(b);
vindobona.Add(c);

// Ausgabe aller Wagons im Zug
Console.WriteLine("Zug besteht aus:");
foreach (var w in vindobona)
{
    Console.WriteLine(w);
}