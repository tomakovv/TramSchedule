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
        private readonly TramStopCommentViewModel _tramStopCommentViewModel;
        private readonly TramStopViewModel _tramStopViewModel;
        private TramScheduleContext _context = new();

        public Form1()
        {
            InitializeComponent();
            _tramViewModel = new TramViewModel(new TramRepository(_context));
            _tramLineViewModel = new TramLineViewModel(new TramLineRepository(_context), new TramStopRepository(_context));
            _tramStopViewModel = new TramStopViewModel(new TramStopRepository(_context));
            _tramStopCommentViewModel = new TramStopCommentViewModel(new TramStopCommentsRepository(_context));
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
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxAllLines.SelectedIndex + 1;
            listBoxLinesStops.DataSource = _tramLineViewModel.GetAllTramStops(selectedIndex).ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var frm = new Form2())
            {
                frm.ShowDialog();
            }
        }

        private void listBoxAllLines_Enter(object sender, EventArgs e)
        {
            buttonAddStopToLine.Visible = true;
        }

        private void listBoxAllLines_Leave(object sender, EventArgs e)
        {
        }

        private void tabControlTrams_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddStopToLine.Visible = false;
            buttonAddCommentToStop.Visible = false;
        }

        private void buttonAddStopToLine_Click(object sender, EventArgs e)
        {
            using (var frm = new FormAddStopToLine())
            {
                frm.ShowDialog();
            }
        }

        private void listBoxTramStops_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxTramStops_Enter(object sender, EventArgs e)
        {
            buttonAddCommentToStop.Visible = true;
        }
    }
}