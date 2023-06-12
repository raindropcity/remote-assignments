using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_2.Controllers
{
    [Route("data")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("data")]
        public IActionResult GetData(int? number)
        {
            if (number == null)
            {
                return BadRequest("Lack of Parameter");
            }
            else if (!int.TryParse(number.ToString(), out int value))
            {
                return BadRequest("Wrong");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= value; i++)
                {
                    sum += i;
                }
                return Ok(sum);
            }
        }
    }
}
