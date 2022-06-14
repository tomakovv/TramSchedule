using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Repositories
{
    public class TramRepository : Repository<Tram>, ITramRepository
    {
        public TramRepository(TramScheduleContext context) : base(context)
        {
        }
    }
}