using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface ITramDeparturesRepository : IRepository<TramDepartures>
    {
        public IEnumerable<TramDepartures> GetTramDeparturesWithDepartureTimes();
    }
}