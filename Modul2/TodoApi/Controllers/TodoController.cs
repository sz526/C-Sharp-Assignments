// Controllers/TodoController.cs
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    // GET: api/todo?isCompleted=false&page=1&pageSize=10
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodos(
        [FromQuery] bool? isCompleted, 
        [FromQuery] int page = 1, 
        [FromQuery] int pageSize = 10)
    {
        // Enkel validering av paginerings-input
        if (page < 1 || pageSize < 1)
        {
            return BadRequest("Page og pageSize må være større enn 0.");
        }

        var todos = await _todoService.GetAllAsync(isCompleted, page, pageSize);
        return Ok(todos);
    }

    // GET: api/todo/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoById(int id)
    {
        var todo = await _todoService.GetByIdAsync(id);
        
        if (todo == null)
        {
            return NotFound(new { Message = $"Oppgave med ID {id} ble ikke funnet." });
        }

        return Ok(todo);
    }

    // POST: api/todo
    [HttpPost]
    public async Task<ActionResult<TodoItem>> CreateTodo([FromBody] TodoItem todoItem)
    {
        // ASP.NET Core validerer [Required] og [StringLength] automatisk via [ApiController],
        // men vi kan også gjøre manuelle sjekker her hvis nødvendig:
        if (todoItem.DueDate.HasValue && todoItem.DueDate.Value < DateTime.UtcNow.Date)
        {
            return BadRequest(new { Error = "Forfallsdato kan ikke være i fortiden." });
        }

        var createdTodo = await _todoService.CreateAsync(todoItem);

        // Returnerer 201 Created, samt en 'Location'-header som peker til det nye objektet
        return CreatedAtAction(nameof(GetTodoById), new { id = createdTodo.Id }, createdTodo);
    }
}