using Microsoft.EntityFrameworkCore;
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

        public TramStop GetTramStopByNumber(int number) => _context.TramStops.AsNoTracking().Where(s => s.Number == number).FirstOrDefault();

        public TramStop GetTramStopWithComments(TramStop stop) => _context.TramStops.Include(t => t.Comments).Where(t => t.TramStopId == stop.TramStopId).SingleOrDefault();

        public TramStop GetTramStopWithDepartures(TramStop stop) => _context.TramStops.Include(t => t.Departures).ThenInclude(d => d.Tram).Include(t => t.Departures).ThenInclude(d => d.DepartureTimes)
            .Where(t => t.TramStopId == stop.TramStopId).SingleOrDefault();
    }
}