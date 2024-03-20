using Microsoft.AspNetCore.Mvc;
using MyMvcProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMvcProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>
        {
            // Example users
            new User { UserId = 1, Username = "Alice", Trips = new List<Trip>() },
            new User { UserId = 2, Username = "Bob", Trips = new List<Trip>() }
        };

        // GET: api/user
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return users;
        }

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // Additional actions to create, update, delete users...
    }
}
