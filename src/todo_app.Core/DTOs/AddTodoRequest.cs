using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.Domain.Entities;

namespace todo_app.Core.DTOs
{
    /// <summary>
    /// DTO for adding new Todo
    /// </summary>
    public class AddTodoRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }

        public Todo toTodo() { 
            return new Todo() { 
                Title = Title, 
                Description = Description, 
                UserId = UserId,
                isCompleted = false

            };
        }
    }
}
