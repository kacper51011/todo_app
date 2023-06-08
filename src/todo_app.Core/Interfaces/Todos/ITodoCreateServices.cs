
using todo_app.Core.DTOs.Todos;

namespace todo_app.Core.Interfaces.Users
{
    /// <summary>
    /// Represents business logic for adding Todo Enitity
    /// </summary>
    public interface ITodoCreateServices
    {
        /// <summary>
        /// Adds todo object to the database
        /// </summary>
        /// <param name="addTodoRequest">
        /// DTO object with values passed by user, coming from TodosController
        /// </param>
        /// <returns>
        /// DTO object with values needed by client (including generated TodoId)
        /// </returns>
      public Task<TodosResponse> AddTodo(AddTodoRequest addTodoRequest);
    }
}
