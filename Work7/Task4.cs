public class SinglyLinkedList<T>
{
    private Node head;
    private int count;

    private class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public int Count => count;
    public bool IsEmpty => count == 0;

    public SinglyLinkedList()
    {
        head = null;
        count = 0;
    }

    public void AddFirst(T item)
    {
        Node newNode = new Node(item);
        newNode.Next = head;
        head = newNode;
        count++;
    }

    public void AddLast(T item)
    {
        Node newNode = new Node(item);

        if (IsEmpty)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        count++;
    }

    public T RemoveFirst()
    {
        if (IsEmpty)
            throw new Exception("List is empty");

        T value = head.Data;
        head = head.Next;
        count--;

        return value;
    }

    public bool Contains(T item)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Data.Equals(item))
                return true;

            current = current.Next;
        }

        return false;
    }
}