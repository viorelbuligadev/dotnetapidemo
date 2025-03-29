using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get(string name)
        {
            return $"Hey, name!";
        }

    }
}
