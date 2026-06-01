using TodoApi.Models;

namespace TodoApi.Services;

public class TodoService : ITodoService
{
    // Simulerer en database i minnet
    private static readonly List<TodoItem> _todos = new();
    private static int _nextId = 1;

    public async Task<IEnumerable<TodoItem>> GetAllAsync(bool? isCompleted, int page, int pageSize)
    {
        // Simulerer nettverks/database-forsinkelse (I/O)
        await Task.Delay(50); 

        var query = _todos.AsQueryable();

        // Filtrering
        if (isCompleted.HasValue)
        {
            query = query.Where(t => t.IsCompleted == isCompleted.Value);
        }

        // Paginering (Sikrer at vi ikke henter alt om listen blir stor)
        return query
            .OrderBy(t => t.CreatedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public async Task<TodoItem?> GetByIdAsync(int id)
    {
        await Task.Delay(50);
        return _todos.FirstOrDefault(t => t.Id == id);
    }

    public async Task<TodoItem> CreateAsync(TodoItem item)
    {
        await Task.Delay(50);
        item.Id = _nextId++;
        item.CreatedAt = DateTime.UtcNow;
        _todos.Add(item);
        return item;
    }
}