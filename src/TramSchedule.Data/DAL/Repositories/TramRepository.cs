using Microsoft.EntityFrameworkCore;
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

        public Tram GetTramWithDepartures(Tram tram) => _context.Trams.Include(t => t.Departures).ThenInclude(t => t.DepartureTimes)
            .Where(t => t.TramId == tram.TramId).FirstOrDefault();
    }
}