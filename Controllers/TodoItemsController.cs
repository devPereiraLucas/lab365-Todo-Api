using lab365_Todo_Api.DTOs;
using lab365_Todo_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab365_Todo_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<int> createTodoItem(TodoItemDto todoItemDto)
        {
            Random random = new();
            int randomId = random.Next(1, 1000);

            TodoItemsModel todoItemsModel = new()
            {
                Id = randomId,
                Name = todoItemDto.Name,
                Active = todoItemDto.Active,
                CreatedAt = DateTime.Now
            };

            return Ok(todoItemsModel.Id);
        }

        [HttpPut("{id}")]
        public ActionResult<bool> updateTodoItem([FromRoute] int id, TodoItemDto todoItemDto)
        {
            return Ok(true);
        }
    }
}
