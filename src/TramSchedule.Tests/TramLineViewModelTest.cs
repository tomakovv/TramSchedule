using NSubstitute;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule.Tests
{
    [TestFixture]
    public class TramLineViewModelTest
    {
        [Test]
        public void AddTramStop_AssignStopThatAlreadyExists_AddValidStop()
        {
            var line = new TramLine() { Name = "testline", TramLineNumber = 1, TramLineId = 1 };
            var stop = new TramStop() { TramStopId = 1, Description = "teststop", Number = 1 };
            var TramLineRepositoryMock = Substitute.For<ITramLineRepository>();
            TramLineRepositoryMock.GetTramLineWithStops(Arg.Any<TramLine>()).Returns(line);
            var TramStopRepositoryMock = Substitute.For<ITramStopRepository>();
            TramStopRepositoryMock.GetTramStopByNumber(Arg.Any<int>())
                .Returns(stop);

            var sut = new TramLineViewModel(TramLineRepositoryMock, TramStopRepositoryMock);
            sut.AddTramStop(line, "1", "test");

            Assert.That(line.Stops.Contains(stop), Is.True);
        }
    }
}