using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Repositories
{
    public class TramStopRepository : Repository<TramStop>, ITramStopRepository
    {
        public TramStopRepository(TramScheduleContext context) : base(context)
        {
        }

        public TramStop GetTramStopByNumber(int number) => _context.TramStops.Where(s => s.Number == number).FirstOrDefault();
    }
}