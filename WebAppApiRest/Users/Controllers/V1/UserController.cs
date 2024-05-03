using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppApiRest.Core.Interfaces;
using WebAppApiRest.Core.Models;

namespace WebAppApiRest.Users.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController(IUserService service) : ControllerBase
    {
        private readonly IUserService _userService = service;

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _userService.ListUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            return Ok(await _userService.FindUser(id));
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] User user)
        {
            await _userService.CreateUser(user);
            return Created();
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<bool>> Patch(int id, [FromBody] User user)
        {
            return Ok(await _userService.UpdateUser(id, user));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return Ok(await _userService.DeleteUser(id));
        } 
    }
}
