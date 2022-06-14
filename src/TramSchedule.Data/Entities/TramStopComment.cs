using System.ComponentModel.DataAnnotations;

namespace TramSchedule.Data.Entities
{
    public class TramStopComment
    {
        [Key]
        public int CommentId { get; set; }

        public string Description { get; set; }
        public TramStop TramStop { get; set; }
    }
}