using APIExample.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIExample.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        public UserController()
        {
        }

        [HttpPost("{region}/create-applicant")]
        public IActionResult CreateApplicant(string region, [FromBody] Applicant model)
        {
            return Ok();
        }
    }
}
