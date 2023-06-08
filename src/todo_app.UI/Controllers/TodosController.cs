using Microsoft.AspNetCore.Mvc;
using todo_app.Core.DTOs.Todos;
using todo_app.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_app.UI.Controllers
{
    public class TodosController : CustomControllerBase
    {
        
        // GET: api/<TodosController>
        [HttpGet]
        public Task<ActionResult<List<Todo>>> GetTodos(GetTodosRequest getTodosRequest)
        {
            
        }

      

        // POST api/<TodosController>
        [HttpPost]
        
        public Task<ActionResult<TodosResponse>> Post(
            [Bind
            (nameof(addTodoRequest.Title), 
            nameof(AddTodoRequest.UserId), 
            nameof(AddTodoRequest.Description))] 
            [FromBody]
            AddTodoRequest? addTodoRequest)
        {

        }

        // PATCH api/<TodosController>/5
        [HttpPatch("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public void Delete(string TodoId, string UserId)
        {
        }
    }
}
