//Task 1
int a = 10;
int b = 20;
Console.WriteLine($"Before swap: a = {a} b = {b}");
Task1.Swap(ref a, ref b);
Console.WriteLine($"After swap: a = {a} b = {b}");


//Task 2
PriorityQueue<string> queue1 = new PriorityQueue<string>();

queue1.Enqueue("Apple", 1);
queue1.Enqueue("Banana", 2);
queue1.Enqueue("Ananas", 3);

Console.WriteLine(queue1.Dequeue());
Console.WriteLine(queue1.Dequeue());
Console.WriteLine(queue1.Dequeue());

//Task 3
CircularQueue<int> queue2 = new CircularQueue<int>(5);

queue2.Enqueue(1);
queue2.Enqueue(2);
queue2.Enqueue(3);
queue2.Enqueue(4);
queue2.Enqueue(5);

Console.WriteLine(queue2.Dequeue());
queue2.Enqueue(6);

Console.WriteLine(queue2.Dequeue());
Console.WriteLine(queue2.Dequeue());
Console.WriteLine(queue2.Dequeue());
Console.WriteLine(queue2.Dequeue());
Console.WriteLine(queue2.Dequeue());


//Task 4
SinglyLinkedList<int> list1 = new SinglyLinkedList<int>();

list1.AddLast(1);
list1.AddLast(2);
list1.AddFirst(5);

Console.WriteLine(list1.RemoveFirst());
Console.WriteLine(list1.Contains(2));
Console.WriteLine(list1.Count);


//Task 5
DoublyLinkedList<int> list2 = new DoublyLinkedList<int>();

list2.AddFirst(1);
list2.AddLast(2);
list2.AddLast(3);

Console.WriteLine(list2.RemoveFirst());
Console.WriteLine(list2.RemoveLast());
Console.WriteLine(list2.Contains(2));
Console.WriteLine(list2.Count);