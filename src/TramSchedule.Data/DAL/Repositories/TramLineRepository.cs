using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Repositories
{
    public class TramLineRepository : Repository<TramLine>, ITramLineRepository
    {
        public TramLineRepository(TramScheduleContext context) : base(context)
        {
        }

        public void AddTramStop(TramStop tramStop)
        {
        }
    }
}