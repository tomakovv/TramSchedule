using TramSchedule.Data.Entities;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface ITramLineRepository : IRepository<TramLine>
    {
        public TramLine GetTramLineWithStops(TramLine line);

        public bool CheckIfLineWithNumberExist(int number);
    }
}