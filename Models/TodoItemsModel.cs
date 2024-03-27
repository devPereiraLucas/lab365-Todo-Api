namespace lab365_Todo_Api.Models
{
    public class TodoItemsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
