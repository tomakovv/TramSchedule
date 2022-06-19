using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;
using TramSchedule.Logic.ViewModels;

internal class main
{
    private static void Main(string[] args)
    {
        TramScheduleContext context = new TramScheduleContext();
        TramLineRepository _tramLineRepo = new TramLineRepository(context);
        TramStopCommentsRepository _tramStopCommentsRepository = new(context);
        TramStopRepository tramStopRepository = new(context);
        TramDeparturesRepository tramDeparturesRepository = new(context);
        TramViewModel tramViewModel = new(new TramRepository(context));
        TramRepository tramRepository = new(context);
        
        var _tram = tramRepository.Get(2);
        var stop = tramStopRepository.Get(7);
        //var time = new TimeSpan(1, 1, 33);
        tramViewModel.AddDeparture(_tram,
           stop, new TimeSpan(3, 3, 33));
        
    }
}