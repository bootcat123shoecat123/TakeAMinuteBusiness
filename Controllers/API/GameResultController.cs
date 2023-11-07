using Microsoft.AspNetCore.Mvc;
using TakeAMinuteBusiness.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TakeAMinuteBusiness.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameResultController : ControllerBase
    {
        // GET: api/<GameResultController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GameResultController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/<GameResultController>
        [HttpPost]
        public string Post([FromBody] GameResultModel value)
        {
            return "Post Succese "+value.ToString();
        }

        // PUT api/<GameResultController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameResultController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
