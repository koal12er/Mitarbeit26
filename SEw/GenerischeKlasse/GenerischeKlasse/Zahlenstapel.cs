namespace GenerischeKlasse;

public class Zahlenstapel
{
    private int pos = -1;
    private int[] zahlen = new int[10];

    public void Push(int number)
    {
        if (pos < zahlen.Length - 1) throw new Exception("Stack is full");
        zahlen[++pos] = number;
    }
    
    public int Pop()
    {
        if (pos < 0) throw new Exception("Stack is empty");
        return zahlen[pos--];
    }
}