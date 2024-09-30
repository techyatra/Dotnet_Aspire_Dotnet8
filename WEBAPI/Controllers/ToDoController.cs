using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private static readonly List<string> todos = new List<string>();

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(todos);
        }

        [HttpPost]
        public ActionResult Post([FromBody] string todo)
        {
            if(String.IsNullOrWhiteSpace(todo))
            {
               return BadRequest("todo is null or empty");
            }
            todos.Add(todo);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if(index < 0 || index >= todos.Count)
            {
                return BadRequest("todo item not found");
            }
            todos.RemoveAt(index);
            return Ok();
        }

    }
}
