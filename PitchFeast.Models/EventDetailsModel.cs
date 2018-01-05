using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFeast.Models
{
    public class EventDetailsModel
    {
        public int EventId { get; set; }

        public Guid OwnerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset EventDate { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
