using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class Form1 : Form
    {
        private readonly TramViewModel _tramViewModel;
        private readonly TramLineViewModel _tramLineViewModel;
        private readonly TramStopViewModel _tramStopViewModel;
        private readonly Form2 _AddNewTramForm;
        private readonly FormAddCommentToStop _formAddCommentToStop;
        private readonly FormAddNewLine _formAddNewLine;
        private readonly FormAddStopToLine _formAddStopToLine;

        public Form1(TramViewModel tramViewModel, TramLineViewModel tramLineViewModel, TramStopViewModel tramStopViewModel, Form2 form2,
            FormAddCommentToStop formAddCommentToStop, FormAddNewLine formAddNewLine, FormAddStopToLine formAddStopToLine)
        {
            InitializeComponent();
            _tramViewModel = tramViewModel;
            _tramLineViewModel = tramLineViewModel;
            _tramStopViewModel = tramStopViewModel;
            _AddNewTramForm = form2;
            _formAddCommentToStop = formAddCommentToStop;
            _formAddNewLine = formAddNewLine;
            _formAddStopToLine = formAddStopToLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = dataGridViewTrams.Columns[3];
            column.Width = 400;
            dataGridViewTrams.DataSource = _tramViewModel.GetAllTrams();
            listBoxAllLines.DataSource = _tramLineViewModel.GetAllTramLines();
            listBoxTramStops.DataSource = _tramStopViewModel.GetAllTramStops();
            listBoxStops.DataSource = _tramStopViewModel.GetAllTramStops();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewTrams_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewTrams_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxTrams.Visible = true;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAllLines.Items.Count > 0)
            {
                var line = (TramLine)listBoxAllLines.SelectedItem;
                listBoxLinesStops.DataSource = _tramLineViewModel.GetAllTramStops(line).ToList();
            }
        }

        private void listBoxAllLines_Enter(object sender, EventArgs e)
        {
            groupBoxLines.Visible = true;
        }

        private void listBoxAllLines_Leave(object sender, EventArgs e)
        {
        }

        private void tabControlTrams_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxLines.Visible = false;
            groupBoxStops.Visible = false;
            groupBoxTrams.Visible = false;
        }

        private void buttonAddStopToLine_Click(object sender, EventArgs e)
        {
            _formAddStopToLine.ListBoxAllLines = listBoxAllLines;
            _formAddStopToLine.ShowDialog();
        }

        private void listBoxTramStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTramStopComments.DataSource = _tramStopViewModel.GetAllStopComments((TramStop)listBoxTramStops.SelectedItem);
        }

        private void listBoxTramStops_Enter(object sender, EventArgs e)
        {
            groupBoxStops.Visible = true;
        }

        private void buttonDeleteLine_Click(object sender, EventArgs e)
        {
            _tramLineViewModel.DeleteLine((TramLine)listBoxAllLines.SelectedItem);
            listBoxAllLines.DataSource = _tramLineViewModel.GetAllTramLines();
        }

        private void buttonAddNewLine_Click(object sender, EventArgs e)
        {
            _formAddNewLine.ListBoxAllLines = listBoxAllLines;
            _formAddNewLine.ShowDialog();
        }

        private void buttonDeleteStopFromLine_Click(object sender, EventArgs e)
        {
            var line = (TramLine)listBoxAllLines.SelectedItem;
            var stop = (TramStop)listBoxLinesStops.SelectedItem;
            _tramLineViewModel.DeleteTramLineStop(line, stop);
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            _formAddCommentToStop.ListBoxAllStops = listBoxTramStops;
            _formAddCommentToStop.ListBoxAllStopComments = listBoxTramStopComments;
            _formAddCommentToStop.ShowDialog();
        }

        private void buttonEditLine_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddNewTram_Click(object sender, EventArgs e)
        {
            _AddNewTramForm.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void listBoxStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stop = (TramStop)listBoxStops.SelectedItem;
            if (stop != null)
            {
                var upcomingDepartures = _tramStopViewModel.GetUpcomingDepartures(stop).ToList();
                listBoxDepartureTimes.DataSource = upcomingDepartures;
            }
        }
    }
}