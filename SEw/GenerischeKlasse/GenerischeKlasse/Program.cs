using GenerischeKlasse;

Console.WriteLine("=== Generischer Stack Demo ===\n");

// Beispiel 1: Stack mit Integers
Console.WriteLine("--- Integer Stack ---");
Stapel<int> zahlenStack = new();

for(int i = 0; i < 5; i++) 
{
    zahlenStack.Push(i * i);
    Console.WriteLine($"Push: {i * i}");
}

Console.WriteLine($"Count: {zahlenStack.Count}");
Console.WriteLine($"Peek: {zahlenStack.Peek()}");

while (!zahlenStack.IsEmpty)
{
    Console.WriteLine($"Pop: {zahlenStack.Pop()}");
}
Console.WriteLine();

// Beispiel 2: Stack mit Strings
Console.WriteLine("--- String Stack ---");
Stapel<string> textStack = new();

textStack.Push("Hallo");
textStack.Push("Servus");
textStack.Push("Griaß di");

Console.WriteLine($"Peek: {textStack.Peek()}");

while (!textStack.IsEmpty)
{
    Console.WriteLine($"Pop: {textStack.Pop()}");
}
Console.WriteLine();

// Beispiel 3: Stack mit Doubles
Console.WriteLine("--- Double Stack ---");
Stapel<double> doubleStack = new();

doubleStack.Push(3.14);
doubleStack.Push(2.71);
doubleStack.Push(1.41);

Console.WriteLine($"Count: {doubleStack.Count}");
while (!doubleStack.IsEmpty)
{
    Console.WriteLine($"Pop: {doubleStack.Pop()}");
}
