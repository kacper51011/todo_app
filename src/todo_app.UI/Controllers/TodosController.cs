using Microsoft.AspNetCore.Mvc;
using todo_app.Core.DTOs.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_app.UI.Controllers
{
    public class TodosController : CustomControllerBase
    {
        // GET: api/<TodosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public void Post([FromBody] AddTodoRequest? addTodoRequest)
        {
        }

        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
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
