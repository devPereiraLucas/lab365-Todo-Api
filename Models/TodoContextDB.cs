using Microsoft.EntityFrameworkCore;

namespace lab365_Todo_Api.Models;

public class TodoContextDB : DbContext
{
    public TodoContextDB(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TodoItemsModel> TodoItemModels { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItemsModel>()
            .Property(p => p.CreatedAt)
            .HasDefaultValueSql("GETDATE()");

        base.OnModelCreating(modelBuilder);
    }
}
