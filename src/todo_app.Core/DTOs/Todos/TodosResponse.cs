using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.Domain.Entities;

namespace todo_app.Core.DTOs.Todos
{
    public class TodosResponse
    {
        public Guid TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool isCompleted { get; set; }

    }

    public static class TodosExtensions
    {
        public static TodosResponse ToTodosResponse(this Todo Todo) {
            return new TodosResponse()
            {
                TodoId = Todo.TodoId,
                Title = Todo.Title,
                Description = Todo.Description,
                isCompleted = Todo.isCompleted
            };
        }
    }
}
