using PitchFeast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFeast.Contracts
{
    public interface IEventService
    {
        bool CreateEvent(EventCreateModel model);
        IEnumerable<EventListModel> GetEvents();
        EventDetailsModel GetEventById(int eventId);
        bool UpdateEvent(EventEditModel model);
        bool DeleteEvent(int quoteId);
    }
}


      