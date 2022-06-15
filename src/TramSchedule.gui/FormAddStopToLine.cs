﻿using TramSchedule.Data.Context;
using TramSchedule.Data.DAL.Repositories;
using TramSchedule.Data.Entities;
using TramSchedule.Logic.ViewModels;

namespace TramSchedule
{
    public partial class FormAddStopToLine : Form
    {
        private readonly TramLineViewModel _tramLineViewModel;
        private readonly TramScheduleContext _context = new();
        public ListBox ListBoxAllLines { get; set; }

        public FormAddStopToLine()
        {
            InitializeComponent();
            _tramLineViewModel = new TramLineViewModel(new TramLineRepository(_context), new TramStopRepository(_context));
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