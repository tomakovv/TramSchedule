using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Logic.ViewModels
{
    public class TramStopCommentViewModel
    {
        private readonly ITramStopCommentsRepository _tramStopCommentsRepository;

        public TramStopCommentViewModel(ITramStopCommentsRepository ramStopCommentsRepository)
        {
            _tramStopCommentsRepository = ramStopCommentsRepository;
        }

        public IEnumerable<TramStopComment> GetAll() => _tramStopCommentsRepository.GetAll();

        public void AddCommentToStop(TramStop tramStop, string description)
        {
            tramStop.Comments.Add(new TramStopComment() { Description = description });
            _tramStopCommentsRepository.Save();
        }
    }
}