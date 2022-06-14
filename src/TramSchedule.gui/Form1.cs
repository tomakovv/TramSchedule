using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;

namespace TramSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            TramRepository repo = new TramRepository(new Data.Context.TramScheduleContext());
            dataGridViewTrams.DataSource = repo.GetAll();
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
        }
    }
}