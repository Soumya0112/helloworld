using HelloWorld.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public readonly IHelloWorldService _helloWorldService;
        public HelloController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _helloWorldService.GetMessage();
        }   


       
    }
}
