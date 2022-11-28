using System.Globalization;
using ca_7.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace ca_7.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
