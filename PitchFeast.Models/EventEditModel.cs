using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFeast.Models
{
    public class EventEditModel
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTimeOffset EventDate { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
