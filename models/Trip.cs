using System;

namespace MyMvcProject.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
