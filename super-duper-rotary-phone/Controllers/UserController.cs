using Microsoft.AspNetCore.Mvc;

namespace super_duper_rotary_phone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        public IActionResult Get()
        {
            return Ok("Result");
        }

        public IActionResult Post()
        {
            return Ok("Result");
        }
    }
}
