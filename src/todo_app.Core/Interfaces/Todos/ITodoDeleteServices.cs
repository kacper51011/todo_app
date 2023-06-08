
using todo_app.Core.DTOs.Todos;

namespace todo_app.Core.Interfaces.Users
{
    internal interface ITodoDeleteServices
    {
       public bool DeleteTodo(DeleteTodoRequest deleteTodoRequest); 
    }
}
