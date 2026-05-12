public class TaskRepository
{
    private static List<TaskItem> _tasks = new()
    {
        new TaskItem
        {
            Id = 1,
            Title = "Learn React Native",
            Completed = false
        },
        new TaskItem
        {
            Id = 2,
            Title = "Learn .NET APIs",
            Completed = true
        }
    };

    public List<TaskItem> GetTasks()
    {
        return _tasks;
    }

    public TaskItem GetTaskById(int id)
    {
        return _tasks.FirstOrDefault(x => x.Id == id);
    }

    public TaskItem AddTask(TaskItem task)
    {
        task.Id = _tasks.Count + 1;

        _tasks.Add(task);

        return task;
    }
}