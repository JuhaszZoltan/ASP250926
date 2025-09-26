using ASP250926.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP250926.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
