public class CircularQueue<T>
{
    private T[] items;
    private int front;
    private int rear;
    private int count;

    public int Capacity { get; }
    public int Count => count;
    public bool IsEmpty => count == 0;
    public bool IsFull => count == Capacity;

    public CircularQueue(int capacity)
    {
        Capacity = capacity;
        items = new T[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (IsFull)
            throw new Exception("Queue is full");

        rear = (rear + 1) % Capacity;
        items[rear] = item;
        count++;
    }

    public T Dequeue()
    {
        if (IsEmpty)
            throw new Exception("Queue is empty");

        T item = items[front];
        front = (front + 1) % Capacity;
        count--;

        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new Exception("Queue is empty");

        return items[front];
    }
}