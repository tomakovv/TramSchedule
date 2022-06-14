using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;

internal class main
{
    private static void Main(string[] args)
    {
        TramScheduleContext context = new TramScheduleContext();
        TramLineRepository _tramLineRepo = new TramLineRepository(context);
        var tramLine = _tramLineRepo.Get(2);
        tramLine.Stops.Add(new TramStop() { Description = "dworzec", Number = 101 });

        _tramLineRepo.Save();
    }
}