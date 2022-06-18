using Microsoft.EntityFrameworkCore;
using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Repositories
{
    public class TramDeparturesRepository : Repository<TramDepartures>, ITramDeparturesRepository
    {
        public TramDeparturesRepository(TramScheduleContext context) : base(context)
        {
        }

        public IEnumerable<TramDepartures> GetTramDeparturesWithDepartureTimes() => _context.TramDepartures.Include(t => t.Tram).Include(t => t.DepartureTimes);
    }
}