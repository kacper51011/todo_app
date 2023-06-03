using Microsoft.EntityFrameworkCore;
using todo_app.Domain.Entities;

namespace todo_app.Infrastructure.DatabaseContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public ApplicationDbContext()
        {
           
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Todo>().ToTable("Todos")

            modelBuilder.Entity<User>().HasData(new User() 
            { 
                Email = "John.Doe@gmail.com",
                UserId = Guid.Parse("BEC90CE0-5CAD-4DE0-9A32-E194B3A1F537"),
                Name="JohnDoe",
                Password="123456" });
            modelBuilder.Entity<Todo>().HasData(new Todo()
            {
                TodoId = Guid.Parse("EB9777C5-8380-47AC-86FA-62A865CC5680"),
                UserId = Guid.Parse("BEC90CE0-5CAD-4DE0-9A32-E194B3A1F537"),
                Title = "Example1",
                Description = "Description Example 1"
            });
            modelBuilder.Entity<Todo>().HasData(new Todo()
            {
                TodoId = Guid.Parse("EB9777C5-8380-47AC-86FA-62A865CC5681"),
                UserId = Guid.Parse("BEC90CE0-5CAD-4DE0-9A32-E194B3A1F537"),
                Title = "Example2",
                Description = "Description Example 2"
            });
        }

    }
}
