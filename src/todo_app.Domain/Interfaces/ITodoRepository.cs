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
        Task<List<Todo>> GetUserTodos(Guid UserId);
        /// <summary>
        /// Change one property of existing todo
        /// </summary>
        /// <param name="todo">
        /// Existing todo with changed property
        /// </param>
        /// <returns>Returns updated Todo from database</returns>
        Task<Todo> UpdateTodo(Todo todo);

        /// <summary>
        /// Delete existing todo from database
        /// </summary>
        /// <param name="TodoId">
        /// Id of existing todo
        /// </param>
        /// <returns>
        /// Boolean, false equals not deleted, true equals deleted 
        /// </returns>

        Task<bool> DeleteTodo(Guid TodoId);


    }
}
