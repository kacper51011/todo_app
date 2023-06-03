
using todo_app.Domain.Entities;

namespace todo_app.Core.DTOs.Todos
{
    /// <summary>
    /// DTO for adding new Todo
    /// </summary>
    public class AddTodoRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }

        public Todo toTodo()
        {
            return new Todo()
            {
                TodoId = Guid.NewGuid(),
                Title = Title,
                Description = Description,
                UserId = UserId,
                isCompleted = false

            };
        }
    }
}
