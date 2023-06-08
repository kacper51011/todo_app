

namespace todo_app.Core.DTOs.Todos
{
    public sealed class DeleteTodoRequest
    {
        Guid UserId { get; set; }
        Guid TodoId { get; set; }
    }
}
