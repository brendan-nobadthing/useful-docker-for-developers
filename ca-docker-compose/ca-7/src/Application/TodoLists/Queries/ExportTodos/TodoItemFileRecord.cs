using ca_7.Application.Common.Mappings;
using ca_7.Domain.Entities;

namespace ca_7.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
