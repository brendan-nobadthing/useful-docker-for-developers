using ca_7.Application.TodoLists.Queries.ExportTodos;

namespace ca_7.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
