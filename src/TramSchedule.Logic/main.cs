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
        // var stop = tramStopRepository.GetTramStopByNumber(103);
        // stop.Comments.Add(new TramStopComment() { Description = "jest ok", TramStop = stop });
        // tramStopRepository.Save();
        var tramLine = _tramLineRepo.Get(1);
        //_tramLineRepo.Delete(tramLine);
        tramLine.Stops.Add(new TramStop() { Description = "dworzec", Number = 121 });
        _tramLineRepo.Save();
        // _tramStopCommentsRepository.Add(new TramStopComment() { Description = "nice stop" });
        // _tramStopCommentsRepository.Save();
        // _tramLineRepo.Add(new TramLine() { Name = "kosciol" });
        // _tramLineRepo.Save();
    }
}