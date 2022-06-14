using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface ITramLineRepository : IRepository<TramLine>
    {
        public void AddTramStop(TramStop tramStop);
    }
}