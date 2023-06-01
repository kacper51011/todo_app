using System.ComponentModel.DataAnnotations;

namespace todo_app.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
