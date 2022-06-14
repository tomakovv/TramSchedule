using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class FormAddStopToLine : Form
    {
        private readonly TramLineViewModel _tramLineViewModel;
        private readonly TramScheduleContext _context = new();

        public FormAddStopToLine()
        {
            InitializeComponent();
            _tramLineViewModel = new TramLineViewModel(new TramLineRepository(_context), new TramStopRepository(_context));
        }

        private void buttonAddStopToLineSave_Click(object sender, EventArgs e)
        {
        }
    }
}