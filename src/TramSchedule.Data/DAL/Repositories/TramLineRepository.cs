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

        public bool CheckIfLineWithNumberExist(int number) => _context.TramLines.Any(t => t.TramLineNumber == number);

        public TramLine GetTramLineWithStops(TramLine line) => _context.TramLines.Include(t => t.Stops).Where(t => t.TramLineId == line.TramLineId).SingleOrDefault();
    }
}