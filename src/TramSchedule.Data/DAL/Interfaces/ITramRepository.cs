using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface ITramRepository : IRepository<Tram>
    {
        Tram GetTramWithDepartures(Tram tram);
    }
}