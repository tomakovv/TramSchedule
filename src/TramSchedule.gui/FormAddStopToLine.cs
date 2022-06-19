using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class FormAddStopToLine : Form
    {
        private readonly TramLineViewModel _tramLineViewModel;
        public ListBox ListBoxAllLines { get; set; }

        public FormAddStopToLine(TramLineViewModel tramLineViewModel)
        {
            InitializeComponent();
            _tramLineViewModel = tramLineViewModel;
        }

        private void buttonAddStopToLineSave_Click(object sender, EventArgs e)
        {
            var name = textBoxnewStopName.Text;
            var number = textBoxNewStopNumber.Text;
            _tramLineViewModel.AddTramStop((TramLine)ListBoxAllLines.SelectedItem, number, name);
            this.Close();
        }
    }
}