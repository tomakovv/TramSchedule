using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class FormAddNewLine : Form
    {
        public ListBox ListBoxAllLines { get; set; }
        private readonly TramLineViewModel _tramLineViewModel;
        private readonly TramScheduleContext _context = new();

        public FormAddNewLine()
        {
            InitializeComponent();
            _tramLineViewModel = new TramLineViewModel(new TramLineRepository(_context), new TramStopRepository(_context));
        }

        private void buttonSaveNewLine_Click(object sender, EventArgs e)
        {
            var name = textBoxNewLineName.Text;
            var number = textBoxNewLineNumber.Text;
            _tramLineViewModel.AddLine(number, name);
            ListBoxAllLines.DataSource = _tramLineViewModel.GetAllTramLines();
            this.Close();
        }
    }
}