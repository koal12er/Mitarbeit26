// See https://aka.ms/new-console-template for more information

string res  ="";
for (int i = 0; i < 10000; i++)
{
    res += "x";// never di th
}
Console.WriteLine(res.Length);