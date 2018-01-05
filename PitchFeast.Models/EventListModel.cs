using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFeast.Models
{
    public class EventListModel
    {
        public int EventId { get; set; }

        public string Event { get; set; }

        public string Description { get; set; }

        [Display(Name = "Date")]
        public DateTimeOffset EventDate { get; set; }

        public override string ToString() => $"[{EventId}] {Event}";
    }
}
