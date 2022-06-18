using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface ITramStopRepository : IRepository<TramStop>
    {
        public TramStop GetTramStopByNumber(int id);

        public TramStop GetTramStopWithComments(TramStop stop);
        TramStop GetTramStopWithDepartures(TramStop stop);
    }
}