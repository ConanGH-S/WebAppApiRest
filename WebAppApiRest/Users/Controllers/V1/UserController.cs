using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppApiRest.Core.Models;

namespace WebAppApiRest.Users.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetAll()
        {
            return "hola";
        }
    }
}
