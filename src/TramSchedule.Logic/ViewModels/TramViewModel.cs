using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramSchedule.Data.DAL.Interfaces;
using TramSchedule.Data.Entities;

namespace TramSchedule.Logic.ViewModels
{
    public class TramViewModel
    {
        private readonly ITramRepository _tramRepository;

        public TramViewModel(ITramRepository tramRepository)
        {
            _tramRepository = tramRepository;
        }

        public IEnumerable<Tram> GetAllTrams() => _tramRepository.GetAll();

        public void AddNewTram(string number, string description, string name)
        {
            if (int.TryParse(number, out int validNumber))
            {
                _tramRepository.Add(new Tram() { Number = validNumber, Description = description, Name = name });
                _tramRepository.Save();
            }
        }
    }
}