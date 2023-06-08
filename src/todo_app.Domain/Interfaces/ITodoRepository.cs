using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.Domain.Entities;

namespace todo_app.Domain.Interfaces
{
    public interface ITodoRepository
    {
        /// <summary>
        /// Adds a new todo object to database
        /// </summary>
        /// <param name="todo">
        /// todo object to add to database
        /// </param>
        /// <returns>
        /// Returns todo object after adding it to database
        /// </returns>
        Task<Todo> AddTodo(Todo todo);

        /// <summary>
        /// Gets all todos of user
        /// </summary>
        /// <param name="UserId">
        /// </param>
        /// <returns>
        /// Returns todos that have UserId matching with provided argument 
        /// </returns>
        Task<List<Todo>> GetAllTodos(Guid UserId);


    }
}
