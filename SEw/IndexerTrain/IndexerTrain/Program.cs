
using IteratorTrain;

Wagon a =  new Wagon{Capacity = 48, Color = "Red"};
Wagon b =  new Wagon{Capacity = 68, Color = "Green"};
Wagon c =  new Wagon{Capacity = 100, Color = "Blue"};

//c.Next = b;
//b.Next = a;

Train vindobona = new Train();
vindobona.Add(a);
vindobona.Add(b);
vindobona.Add(c);

Console.WriteLine(vindobona.ToString());
