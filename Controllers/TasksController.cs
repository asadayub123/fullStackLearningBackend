using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly TaskService _service;

    public TasksController(TaskService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok(_service.GetTasks());
    }

    [HttpGet("{id}")]
    public IActionResult GetTaskById(int id)
    {
        return Ok(_service.GetTaskById(id));
    }

    [HttpPost]
    public IActionResult AddTask(TaskItem task)
    {
        return Ok(_service.AddTask(task));
    }
}