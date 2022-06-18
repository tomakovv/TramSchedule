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
        //TramStopViewModel tramStopViewModel = new(new TramStopRepository(context));
        // var tram = tramDeparturesRepository.GetTramDeparturesWithDepartureTimes();
        //tramDeparturesRepository.Add(new TramDepartures()
        //{
        //    Stop = new TramStop() { Number = 111, Description = "A" },
        //    Tram = new Tram() { Name = "a", Number = 9, Description = "s" }
        //});
        // tram.DepartureTimes.Add(new DepartureTime() { Time = new TimeSpan(3, 13, 1) });
        var _tram = tramRepository.Get(1);
        var stop = tramStopRepository.Get(7);
        //var time = new TimeSpan(1, 1, 33);
        tramViewModel.AddDeparture(_tram,
           stop, new TimeSpan(3, 3, 33));
        //var departures = tramStopViewModel.GetUpcomingDepartures(stop);

        //foreach (var item in departures)
        //{
        //    Console.WriteLine(item);
        //}
    }
}