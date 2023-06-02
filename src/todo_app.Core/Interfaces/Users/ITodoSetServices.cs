
using todo_app.Core.DTOs.Todos;

namespace todo_app.Core.Interfaces.Users
{
    public interface ITodoSetServices
    {
        TodosResponse AddTodo(AddTodoRequest addTodoRequest);
    }
}
