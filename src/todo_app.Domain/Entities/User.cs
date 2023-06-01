using System.ComponentModel.DataAnnotations;

namespace todo_app.Domain.Entities
{
    /// <summary>
    /// Domain Model for User data
    /// </summary>
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}
