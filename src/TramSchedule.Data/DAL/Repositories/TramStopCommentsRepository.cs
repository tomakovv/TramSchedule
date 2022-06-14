using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Repositories
{
    public class TramStopCommentsRepository : Repository<TramStopComment>, ITramStopCommentsRepository
    {
        public TramStopCommentsRepository(TramScheduleContext context) : base(context)
        {
        }
    }
}