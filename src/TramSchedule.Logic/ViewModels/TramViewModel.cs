using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Logic.ViewModels
{
    public class TramViewModel
    {
        private readonly ITramRepository _tramRepository;

        public TramViewModel(ITramRepository tramRepository)
        {
            _tramRepository = tramRepository;
        }

        public IEnumerable<Tram> GetAllTrams() => _tramRepository.GetAll();

        public void AddNewTram(string number, string description, string name)
        {
            if (int.TryParse(number, out int validNumber))
            {
                _tramRepository.Add(new Tram() { Number = validNumber, Description = description, Name = name });
                _tramRepository.Save();
            }
        }

        public void AddDeparture(Tram tram, TramStop tramStop, TimeSpan time)
        {
            tram = _tramRepository.GetTramWithDepartures(tram);
            var departure = tram.Departures.Where(d => d.Stop.TramStopId == tramStop.TramStopId && d.Tram.TramId == tram.TramId).FirstOrDefault();
            if (departure == null)
            {
                tram.Departures.Add(new TramDepartures(new DepartureTime() { Time = time }) { Stop = tramStop });
                _tramRepository.Save();
                return;
            }
            departure.DepartureTimes.Add(new DepartureTime() { Time = time });
            _tramRepository.Save();
        }
    }
}