using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class FormAddNewLine : Form
    {
        public ListBox ListBoxAllLines { get; set; }
        private readonly TramLineViewModel _tramLineViewModel;

        public FormAddNewLine(TramLineViewModel tramLineViewModel)
        {
            InitializeComponent();
            _tramLineViewModel = tramLineViewModel;
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