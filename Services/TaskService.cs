public class TaskService
{
    private readonly TaskRepository _repository;

    public TaskService(TaskRepository repository)
    {
        _repository = repository;
    }

    public List<TaskItem> GetTasks()
    {
        return _repository.GetTasks();
    }

    public TaskItem GetTaskById(int id)
    {
        return _repository.GetTaskById(id);
    }

    public TaskItem AddTask(TaskItem task)
    {
        return _repository.AddTask(task);
    }
}