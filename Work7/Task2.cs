public class PriorityQueue<T>
{
    private List<T> items = new List<T>();
    private List<int> priorities = new List<int>();

    public void Enqueue(T item, int priority)
    {
        items.Add(item);
        priorities.Add(priority);
    }

    public T Dequeue()
    {
        if (items.Count == 0)
            throw new Exception("Queue is empty");

        int minIndex = 0;

        for (int i = 1; i < priorities.Count; i++)
        {
            if (priorities[i] < priorities[minIndex])
            {
                minIndex = i;
            }
        }

        T result = items[minIndex];
        items.RemoveAt(minIndex);
        priorities.RemoveAt(minIndex);

        return result;
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}