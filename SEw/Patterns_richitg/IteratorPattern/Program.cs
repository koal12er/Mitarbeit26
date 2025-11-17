using IteratorPattern;

Person[] friends = new []
{
    new Person{FirstName = "John", LastName = "Doe"},
    new Person{FirstName = "Jane", LastName = "Doe"}
};

Team _3chit = new Team(friends);

for (int i = 0; i < _3chit.NumberOfMembers; i++)
{
    Console.WriteLine(_3chit[i]);
}

foreach (Person p in _3chit)
{
    Console.WriteLine(p);
}