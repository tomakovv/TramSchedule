using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;

internal class main
{
    private static void Main(string[] args)
    {
        TramScheduleContext context = new TramScheduleContext();
        TramLineRepository _tramLineRepo = new TramLineRepository(context);
        TramStopCommentsRepository _tramStopCommentsRepository = new(context);
        TramStopRepository tramStopRepository = new(context);
        var stop = tramStopRepository.GetTramStopByNumber(103);
        stop.Comments.Add(new TramStopComment() { Description = "jest ok", TramStop = stop });
        tramStopRepository.Save();
        // var tramLine = _tramLineRepo.Get(2);
        //tramLine.Stops.Add(new TramStop() { Description = "dworzec", Number = 101 });
        // _tramStopCommentsRepository.Add(new TramStopComment() { Description = "nice stop" });
        // _tramStopCommentsRepository.Save();
        //_tramLineRepo.Save();
    }
}