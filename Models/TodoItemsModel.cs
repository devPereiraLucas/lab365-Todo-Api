using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab365_Todo_Api.Models;

[Table("TodoItem")]
public class TodoItemsModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column(TypeName = "VARCHAR"), StringLength(250), Required]
    public string Name { get; set; }
    [Required]
    public bool Active { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
}
