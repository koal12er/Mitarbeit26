namespace LiList;

public class MyLinkedList
{
    public MyElement Head {get; set;}


    public void AddFirst(int value)
    {
        MyElement tmp = new MyElement{value = value};
        if (Head != null)
            tmp.Next = Head;
        Head = tmp;
    }

    public void AddLast(int value)
    {
        if (Head == null)
            Head = new MyElement{value = value};
        else {
            MyElement tmp = Head;
            while (tmp.Next != null) tmp = tmp.Next;
            tmp.Next = new MyElement{value = value};
        }
    }
    public override string ToString()
    {
        return Head.ToString();
    }
    
    
}