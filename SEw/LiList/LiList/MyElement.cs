namespace LiList;

public class MyElement
{
    public MyElement Next { get; set; }
    public int value { get; set; }

    override public string ToString()
    {
        return Next == null ? value.ToString() 
            : value + ">" + Next.ToString();
    }
}