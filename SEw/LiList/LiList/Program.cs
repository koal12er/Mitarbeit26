using LiList;

MyLinkedList list = new MyLinkedList();
list.AddFirst(17);
list.AddFirst(2);
list.AddFirst(33);
list.AddFirst(8);

Console.WriteLine(list);
list.Remove(33);
Console.WriteLine(list);