using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramSchedule.Data.Entities
{
    public class Tram
    {
        public int TramId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}