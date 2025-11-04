// See https://aka.ms/new-console-template for more information

using FactoryMethodPattern;

Restaurant Keskin = new Pizzeria();
// Die Mahlzeit wird von der Factory Method geliefert
Mahlzeit meine = Keskin.MahlzeitLiefern();
Console.WriteLine("Ich esse " + meine.ToString());

Console.WriteLine("------------------------");

Restaurant Gyrosvanni = new Kebabbude();
// Die Mahlzeit wird von der Factory Method geliefert
Mahlzeit deine = Gyrosvanni.MahlzeitLiefern();
Console.WriteLine("Du isst " + deine.ToString());


Console.WriteLine("------------------------");

Restaurant Schoen= new Cafe();
// Die Mahlzeit wird von der Factory Method geliefert
Mahlzeit seine = Schoen.MahlzeitLiefern();
Console.WriteLine("Er isst " + seine.ToString());


Console.WriteLine("------------------------");

Restaurant Markt= new Weihnachtsmarkt();
// Die Mahlzeit wird von der Factory Method geliefert
Mahlzeit ihre = Markt.MahlzeitLiefern();
Console.WriteLine("Sie isst " + ihre.ToString());