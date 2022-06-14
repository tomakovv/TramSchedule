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
            tramBindingSource.DataSource = new List<Tram>() {
                new Tram() { TramId = 1, Description = "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd", Name = "name", Number = 2 },
                new Tram() { TramId = 2, Description = "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd", Name = "name1", Number = 23 }
            };
            DataGridViewColumn column = dataGridViewTrams.Columns[3];
            column.Width = 400;
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