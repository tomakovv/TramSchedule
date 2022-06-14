namespace TramSchedule.Data.Entities
{
    public class TramStop
    {
        public TramStop()
        {
            Comments = new();
        }

        public int TramStopId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public List<TramStopComment> Comments { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}