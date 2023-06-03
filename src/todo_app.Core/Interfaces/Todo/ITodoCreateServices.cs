
using todo_app.Core.DTOs.Todos;

namespace todo_app.Core.Interfaces.Users
{
    public interface ITodoCreateServices
    {
        Task<TodosResponse> AddTodo(AddTodoRequest addTodoRequest);
    }
}
