using System.Reflection.Metadata.Ecma335;

namespace Baum;

public class MyElement {
    public int Value { get; set; }
    public MyElement Left { get; set; }
    public MyElement Right { get; set; }

    public override string ToString()
    {
    return Value.ToString();
    }
}

public class MyBinaryTree {
    public MyElement Root { get; set; }

    public void Insert(MyElement element)
    {
        // wenn leer Root setzen
        if (Root == null) {
            Root = element;
            return;
        }
        else {
            Insert(Root, element);
        }
    }

    public void Insert(MyElement current, MyElement element)
    {
        // wenn element kleiner als current und links null ist > einfügen
        if (current.Left == null && element.Value < current.Value) {
            current.Left = element;
        }

        else if (current.Right == null && element.Value >= current.Value) {
            current.Right = element;
        }

        else {
            if (element.Value < current.Value) {
                Insert(current.Left, element);
            }

            else {
                Insert(current.Right, element);
            }
        }
    }

    public MyElement Minimum()
    {
        if (Root == null) {
            return null;
        }
        return Minimum(Root);
    }
 
    private MyElement Minimum(MyElement current)
    {
        MyElement tmp = current;
        while (tmp.Left != null) {
            tmp = tmp.Left;
        }
        return tmp;
    }

    public MyElement Find(int value)
    {
        if (Root == null) return null;
        return Find(Root, value);
    }
 
    private MyElement Find(MyElement current, int element)
    {
        if (current == null) {
            return null;
        }

        else if (current.Value == element) {
            return current;
        }

        else if (element < current.Value) {
            return Find(current.Left, element);
        }

        else {
            return Find(current.Right, element);
        }
    }

    public MyElement Delete(int value)
    {
        return Delete(Root, value);
    }

    private MyElement Delete(MyElement current, int element)
    {
        if (current == null) {
            return null;
        }

        if (element < current.Value) {
            current.Left = Delete(current.Left, element);
        }
        else if (element > current.Value) {
            current.Right = Delete(current.Right, element);
        }
        else {
            if (current.Left == null) {
                return current.Right;
            }
            else if (current.Right == null) {
                return current.Left;
            }
         
            MyElement temp = Minimum(current.Right);
            current.Value = temp.Value;
            current.Right = Delete(current.Right, temp.Value);
        }

        return current;
    }
 
    public void Inorder() => Inorder(Root);// Startet die Inorder-Traversierung ab dem Wurzelknoten
    public void Inorder(MyElement element)
    {
        if (element == null) return;
        Inorder(element.Left);
        Console.Write(element.Value + " ");
        Inorder(element.Right);
    }
}