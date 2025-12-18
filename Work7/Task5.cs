public class DoublyLinkedList<T>
{
    private Node head;
    private Node tail;
    private int count;

    private class Node
    {
        public T Data;
        public Node Next;
        public Node Prev;

        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    public int Count => count;
    public bool IsEmpty => count == 0;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddFirst(T item)
    {
        Node newNode = new Node(item);

        if (IsEmpty)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        count++;
    }

    public void AddLast(T item)
    {
        Node newNode = new Node(item);

        if (IsEmpty)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        count++;
    }

    public T RemoveFirst()
    {
        if (IsEmpty)
            throw new Exception("List is empty");

        T value = head.Data;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.Next;
            head.Prev = null;
        }

        count--;
        return value;
    }

    public T RemoveLast()
    {
        if (IsEmpty)
            throw new Exception("List is empty");

        T value = tail.Data;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.Prev;
            tail.Next = null;
        }

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
