using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todo_app.Domain.Entities

{
    /// <summary>
    /// Domain Model for Todo details
    /// </summary>
    public class Todo
    {
        [Key]
        public Guid TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool isCompleted { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
