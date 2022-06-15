using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Logic.ViewModels
{
    public class TramStopViewModel
    {
        private readonly ITramStopRepository _tramStopRepository;

        public TramStopViewModel(ITramStopRepository tramStopRepository)
        {
            _tramStopRepository = tramStopRepository;
        }

        public IEnumerable<TramStop> GetAllTramStops() => _tramStopRepository.GetAll();

        public void AddCommentToStop(TramStop stop, string comment)
        {
            stop = _tramStopRepository.GetTramStopWithComments(stop);
            if (!string.IsNullOrEmpty(comment))
            {
                stop.Comments.Add(new TramStopComment() { Description = comment });
                _tramStopRepository.Save();
            }
        }

        public IEnumerable<TramStopComment> GetAllStopComments(TramStop stop)
        {
            stop = _tramStopRepository.GetTramStopWithComments(stop);
            return stop.Comments;
        }
    }
}