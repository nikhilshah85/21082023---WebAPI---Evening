using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace greetingsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {

        [HttpGet]
        [Route("/greet")]
        public IActionResult Greetings()
        {
            //methods will always return HttpStatus Code and Message
            return Ok("Hello and Welcome to WebAPI Development World");
        }


        [HttpGet]
        [Route("/greet/{name}")]
        public IActionResult Greetings(string name)
        {
            return Ok("Hello " + name);
        }


        [HttpGet]
        [Route("/friends")]
        public IActionResult friends()
        {
            List<string> friendList = new List<string>()
            {
                "Akshay","Rahul","Rohit","Mohit","Suman"
            };
            return Ok(friendList);
        }
    }
}
