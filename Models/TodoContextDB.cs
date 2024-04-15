using Microsoft.EntityFrameworkCore;

namespace lab365_Todo_Api.Models;

public class TodoContextDB : DbContext
{
    public TodoContextDB(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TodoItemsModel> TodoItemModels { get; set; }
}
