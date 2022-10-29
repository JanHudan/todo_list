using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Model;

namespace ToDoListAPI.Data
{
    public class ToDoTaskDbContext : DbContext
    {
        public ToDoTaskDbContext(DbContextOptions<ToDoTaskDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<ToDoTask>? ToDoTasks { get; set; }
    }
}