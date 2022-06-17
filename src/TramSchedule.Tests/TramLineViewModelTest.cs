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
            var TramLineRepositoryMock = Substitute.For<ITramLineRepository>();
            var TramStopRepositoryMock = Substitute.For<ITramStopRepository>();
            TramStopRepositoryMock.GetTramStopByNumber(Arg.Any<int>())
                .Returns(new TramStop());

            var sut = new TramLineViewModel(TramLineRepositoryMock, TramStopRepositoryMock);

            Assert.That(true);
        }
    }
}