using Microsoft.AspNetCore.Mvc;

namespace InverterService_API.Controllers
{
    [Route("api/inverter")]
    [ApiController]
    public class InverterController : ControllerBase
    {
        [HttpGet]
        [Route("{word}")]
        public IActionResult ConvertString(string word)
        {
            string reverseWordString = string.Join(" ", word
             .Split(' ')
             .Select(x => new String(x.Reverse().ToArray())));

            return Ok(reverseWordString);
        }
    }
}
