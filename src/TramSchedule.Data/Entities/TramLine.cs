namespace TramSchedule.Data.Entities
{
    public class TramLine
    {
        public TramLine()
        {
            Stops = new();
        }

        public int Number { get; set; }
        public int LineNumber { get; set; }
        public List<TramStop> Stops { get; set; }
    }
}