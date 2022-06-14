using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Logic.ViewModels
{
    public class TramLineViewModel
    {
        private readonly ITramLineRepository _tramLineRepository;
        private readonly ITramStopRepository _tramStopRepository;

        public TramLineViewModel(ITramLineRepository tramLineRepository, ITramStopRepository tramStopRepository)
        {
            _tramLineRepository = tramLineRepository;
            _tramStopRepository = tramStopRepository;
        }

        public IEnumerable<TramLine> GetAllTramLines() => _tramLineRepository.GetAll();

        public IEnumerable<TramStop> GetAllTramStops(int index)
        {
            if (index <= 0) return Enumerable.Empty<TramStop>();
            var line = _tramLineRepository.GetTramLineWithStops(index);
            return line.Stops;
        }

        public void AddTramStop(int index, int stopNumber, string name)
        {
            var line = _tramLineRepository.GetTramLineWithStops(index);
            var stop = _tramStopRepository.GetTramStopByNumber(stopNumber);
            if (stop == null)
            {
                line.Stops.Add(new TramStop() { Number = stopNumber, Description = name });
                _tramLineRepository.Save();
                return;
            }
            line.Stops.Add(stop);
            _tramLineRepository.Save();
        }
    }
}