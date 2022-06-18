namespace TramSchedule.Data.Entities
{
    public class TramStop
    {
        public TramStop()
        {
            Comments = new();
            Lines = new();
            Departures = new();
        }

        public int TramStopId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public List<TramStopComment> Comments { get; set; }
        public List<TramLine> Lines { get; set; }
        public List<TramDepartures> Departures { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}