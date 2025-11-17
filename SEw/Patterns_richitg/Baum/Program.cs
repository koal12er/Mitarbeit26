// See https://aka.ms/new-console-template for more information

using Baum;

MyBinaryTree myBinaryTree = new MyBinaryTree();

myBinaryTree.Insert(new MyElement{Value = 55});
myBinaryTree.Insert(new MyElement{Value = 27});
myBinaryTree.Insert(new MyElement{Value = 28});
myBinaryTree.Insert(new MyElement{Value = 13});
myBinaryTree.Insert(new MyElement{Value = 59});
myBinaryTree.Insert(new MyElement{Value = 54});
myBinaryTree.Insert(new MyElement{Value = 99});

myBinaryTree.Inorder();
Console.WriteLine();

Console.WriteLine("-----------------------");

Console.WriteLine("Minimum: " + myBinaryTree.Minimum());

Console.WriteLine("Found: " + myBinaryTree.Find(13));

myBinaryTree.Delete(59);

Console.WriteLine("Found: " + myBinaryTree.Find(59));



//MyBinaryTree myBinaryTree2 = new MyBinaryTree();
//for (int i = 0; i < 10000; i++)
//{
//    myBinaryTree2.Insert(new MyElement{Value = i});
//}
//myBinaryTree2.Inorder();

