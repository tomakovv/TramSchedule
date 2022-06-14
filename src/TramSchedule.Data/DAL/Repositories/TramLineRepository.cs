using Microsoft.EntityFrameworkCore;
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

        public TramLine GetTramLineWithStops(int id)
        {
            return _context.TramLines.Include(t => t.Stops).Where(t => t.TramLineId == id).SingleOrDefault();
        }
    }
}