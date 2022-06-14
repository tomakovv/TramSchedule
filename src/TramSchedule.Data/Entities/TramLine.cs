﻿namespace TramSchedule.Data.Entities
{
    public class TramLine
    {
        public TramLine()
        {
            Stops = new();
        }

        public int TramLineId { get; set; }
        public string Name { get; set; }
        public List<TramStop> Stops { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}