using System.ComponentModel.DataAnnotations;

namespace TramSchedule.Data.Entities
{
    public class TramDepartures
    {
        public TramDepartures()
        {
            DepartureTimes = new();
        }

        public TramDepartures(DepartureTime time)
        {
            DepartureTimes = new() { time };
        }

        [Key]
        public int TramDepartureID { get; set; }

        public Tram Tram { get; set; }
        public List<DepartureTime> DepartureTimes { get; set; }
        public TramStop Stop { get; set; }
    }
}