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

#if DEBUG

        modelBuilder.Entity<TodoItemsModel>()
            .HasData(
                new TodoItemsModel { Id = 1, Name = "Item 1", Active = false, CreatedAt = DateTime.Now },
                new TodoItemsModel { Id = 2, Name = "Item 2", Active = true, CreatedAt = DateTime.Now },
                new TodoItemsModel { Id = 3, Name = "Item 3", Active = false, CreatedAt = DateTime.Now }
            );
#endif

        base.OnModelCreating(modelBuilder);
    }
}
