using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController(DataContext context) : ControllerBase
    {
        //Always practise to use async 
        [HttpGet("GetUsers")]
        public async Task<ActionResult<IEnumerable<AppUser>>> GerUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }
        [HttpGet("GetUser/{id:int}")]
        public async Task<ActionResult<AppUser>> GerUser(int id)
        {
            var user =await context.Users.FindAsync(id);
            return Ok(user);
        }
    }
}
