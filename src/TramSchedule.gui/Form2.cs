using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class Form2 : Form
    {
        private TramViewModel _tramViewModel;

        public Form2(TramViewModel tramViewModel)
        {
            InitializeComponent();
            _tramViewModel = tramViewModel;
        }

        private void buttonSaveNewTram_Click(object sender, EventArgs e)
        {
            string number = textBoxNewTramNumber.Text;
            string name = textBoxNewTramName.Text;
            string description = richTextBoxNewTramDescription.Text;
            _tramViewModel.AddNewTram(number, description, name);
            this.Close();
        }
    }
}