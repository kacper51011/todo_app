using todo_app.Core.DTOs.Todos;
using todo_app.Core.Interfaces.Users;
using todo_app.Domain.Entities;

namespace todo_app.Core.Services.Todos
{
    public class TodoCreateServices : ITodoCreateServices
    {
        private readonly ApplicationDbContext _applicationDbContext

        public TodoCreateServices(ApplicationDbContext )
        
        public async Task<TodosResponse> AddTodo(AddTodoRequest addTodoRequest)
        {
            Todo todo = addTodoRequest.toTodo();

            return todo.ToTodosResponse();

        }
    }
}
