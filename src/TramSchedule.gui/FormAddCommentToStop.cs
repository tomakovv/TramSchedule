using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class FormAddCommentToStop : Form
    {
        public ListBox ListBoxAllStops { get; set; }
        public ListBox ListBoxAllStopComments { get; set; }
        private readonly TramStopViewModel _tramStopViewModel;
        private readonly TramScheduleContext _context = new();

        public FormAddCommentToStop()
        {
            InitializeComponent();
            _tramStopViewModel = new(new TramStopRepository(_context));
        }

        private void buttonSaveComment_Click(object sender, EventArgs e)
        {
            var text = richTextBox1.Text;
            var stop = (TramStop)ListBoxAllStops.SelectedItem;
            _tramStopViewModel.AddCommentToStop(stop, text);
            ListBoxAllStopComments.DataSource = _tramStopViewModel.GetAllStopComments(stop);
            this.Close();
        }
    }
}