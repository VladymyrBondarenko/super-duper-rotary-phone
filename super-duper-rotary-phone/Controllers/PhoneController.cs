using Microsoft.AspNetCore.Mvc;

namespace super_duper_rotary_phone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhoneController : ControllerBase
    {
        public PhoneController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Result");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return CreatedAtAction("Post", "Result");
        }
    }
}
