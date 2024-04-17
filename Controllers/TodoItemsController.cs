using lab365_Todo_Api.DTOs;
using lab365_Todo_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab365_Todo_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoItemsController : ControllerBase
{
    private readonly TodoContextDB _todoContextDB;

    public TodoItemsController(TodoContextDB todoContextDB)
    {
        _todoContextDB = todoContextDB;
    }

    /// <summary>
    ///     Verbo POST - CREATE - Criar um novo registro no Banco de Dados
    /// </summary>
    /// <param name="todoItemDto"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<int> CreateTodoItem(TodoItemDto todoItemDto)
    {
        TodoItemsModel todoItemsModel = new()
        {
            Name = todoItemDto.Name,
            Active = todoItemDto.Active,
            CreatedAt = DateTime.Now
        };

        _todoContextDB.TodoItemModels.Add(todoItemsModel);
        _todoContextDB.SaveChanges();

        return Ok(todoItemsModel.Id);
    }

    /// <summary>
    ///    Verbo PUT - UPDATE - Atualiza um registro no Banco de Dados
    /// </summary>
    /// <param name="id"></param>
    /// <param name="todoItemDto"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public ActionResult<bool> UpdateTodoItem([FromRoute] int id, TodoItemDto todoItemDto)
    {
        TodoItemsModel todoItemsModel = new()
        {
            Id = id,
            Name = todoItemDto.Name,
            Active = todoItemDto.Active,
        };

        return Ok(true);
    }

    /// <summary>
    ///    Verbo DELETE - DELETE - Deleta um registro no Banco de Dados
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public ActionResult DeleteTodoItem([FromRoute] int id)
    {
        return Ok();
    }

    /// <summary>
    ///   Verbo GET - READ - Retorna todos os registros do Banco de Dados
    /// </summary>
    /// <returns></returns>
    [HttpGet()]
    public ActionResult<IEnumerable<TodoItemDto>> GetTodoItem()
    {
        return Ok();
    }

    /// <summary>
    ///   Verbo GET - READ - Retorna um registro do Banco de Dados
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public ActionResult<TodoItemDto> GetTodoItemById([FromRoute] int id)
    {
        return Ok();
    }
}
