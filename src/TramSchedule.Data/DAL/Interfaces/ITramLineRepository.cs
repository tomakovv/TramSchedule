using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface ITramLineRepository : IRepository<TramLine>
    {
        public TramLine GetTramLineWithStops(int id);
    }
}