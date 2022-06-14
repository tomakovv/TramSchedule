using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;

namespace TramSchedule.Logic.ViewModels
{
    public class TramStopViewModel
    {
        private readonly TramStopRepository _tramStopRepository;

        public TramStopViewModel(TramStopRepository tramStopRepository)
        {
            _tramStopRepository = tramStopRepository;
        }

        public IEnumerable<TramStop> GetAllTramStops() => _tramStopRepository.GetAll();
    }
}