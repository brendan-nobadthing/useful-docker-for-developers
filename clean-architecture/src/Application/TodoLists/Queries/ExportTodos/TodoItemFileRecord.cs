using clean_architecture.Application.Common.Mappings;
using clean_architecture.Domain.Entities;

namespace clean_architecture.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
