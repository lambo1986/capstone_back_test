using System.Collections.Generic;

namespace MyMvcProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
