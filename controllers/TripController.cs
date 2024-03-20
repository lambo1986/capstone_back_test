using Microsoft.AspNetCore.Mvc; 
using MyMvcProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMvcProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private static List<Trip> trips = new List<Trip>
        {
            // Example trips
            new Trip { TripId = 1, Destination = "Paris", Date = DateTime.UtcNow, UserId = 1 },
            // Add more trips
        };

        // GET: api/trip
        [HttpGet]
        public ActionResult<IEnumerable<Trip>> GetTrips()
        {
            return trips;
        }

        // GET: api/trip/{id}
        [HttpGet("{id}")]
        public ActionResult<Trip> GetTrip(int id)
        {
            var trip = trips.FirstOrDefault(t => t.TripId == id);
            if (trip == null)
            {
                return NotFound();
            }
            return trip;
        }

        // Additional actions to create, update, delete trips...
    }
}
