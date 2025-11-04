using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        const int N = 100000; // Anzahl Schleifendurchläufe
        double nsPerTick = (1_000_000_000.0) / Stopwatch.Frequency; // Nanosekunden pro Tick

        // -----------------------------
        // Variante 1: String +=
        // -----------------------------
        string res = "";
        Stopwatch sw1 = Stopwatch.StartNew();

        for (int i = 0; i < N; i++)
        {
            res += "x";
        }

        sw1.Stop();
        double ns1 = sw1.ElapsedTicks * nsPerTick;
        Console.WriteLine($"String += Länge: {res.Length}, Zeit: {ns1:F0} ns");

        // -----------------------------
        // Variante 2: StringBuilder
        // -----------------------------
        StringBuilder sb = new StringBuilder();
        Stopwatch sw2 = Stopwatch.StartNew();

        for (int i = 0; i < N; i++)
        {
            sb.Append("x");
        }

        res = sb.ToString();
        sw2.Stop();
        double ns2 = sw2.ElapsedTicks * nsPerTick;
        Console.WriteLine($"StringBuilder Länge: {res.Length}, Zeit: {ns2:F0} ns");

        // -----------------------------
        // Vergleich
        // -----------------------------
        Console.WriteLine($"StringBuilder ist {ns1 / ns2:F2}x schneller als += ");
    }
}