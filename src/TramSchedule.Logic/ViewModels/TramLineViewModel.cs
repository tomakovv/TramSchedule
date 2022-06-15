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

        public IEnumerable<TramStop> GetAllTramStops(TramLine line)
        {
            line = _tramLineRepository.GetTramLineWithStops(line);
            return line.Stops;
        }

        public void AddTramStop(TramLine line, string number, string name)
        {
            if (int.TryParse(number, out int stopNumber))
            {
                var stop = _tramStopRepository.GetTramStopByNumber(stopNumber);
                line = _tramLineRepository.GetTramLineWithStops(line);
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

        public void AddLine(string number, string name)
        {
            if (int.TryParse(number, out int lineNumber))
            {
                if (!_tramLineRepository.CheckIfLineWithNumberExist(lineNumber))
                {
                    _tramLineRepository.Add(new TramLine() { Name = name, TramLineNumber = lineNumber });
                    _tramLineRepository.Save();
                }
            }
        }

        public void DeleteLine(TramLine line)
        {
            line = _tramLineRepository.GetTramLineWithStops(line);
            _tramLineRepository.Delete(line);
            _tramLineRepository.Save();
        }

        public void DeleteTramLineStop(TramLine line, TramStop stop)
        {
            line = _tramLineRepository.GetTramLineWithStops(line);
            if (line.Stops.Any(s => s.Number == stop.Number))
            {
                line.Stops.Remove(stop);
                _tramLineRepository.Save();
            }
        }
    }
}