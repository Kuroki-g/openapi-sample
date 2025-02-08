using Microsoft.EntityFrameworkCore;

using MinimalWebApi.Models;

namespace MinimalWebApi;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}
 
 