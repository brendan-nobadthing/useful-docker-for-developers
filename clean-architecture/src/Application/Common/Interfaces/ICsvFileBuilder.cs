using clean_architecture.Application.TodoLists.Queries.ExportTodos;

namespace clean_architecture.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
