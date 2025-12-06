namespace ToDoList
{
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        Deferred
    }

    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; protected set; }

        public Task(string title, string description)
        {
            Title = title;
            Description = description;
            Status = TaskStatus.NotStarted;
        }
        
        private List<Task> tasks = new List<Task>();
        
        public void UpdateStatus(TaskStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Task '{Title}' updated to {Status}");
        }
        
        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine($"Added task: {task.Title}");
        }
        
        public void PrintTasksByStatus(TaskStatus status)
        {
            Console.WriteLine($"\nTasks with status {status}:");
            foreach (var task in tasks)
            {
                if (task.Status == status)
                {
                    Console.WriteLine($"{task.Title}: {task.Description}");
                }
            }
        }
    }
}