using PitchFeast.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PitchFeast.Models;
using PitchFeast.Data;
using KidQuotes.Data;

namespace PitchFeast.Services
{
    public class EventService : IEventService
    {
        private readonly Guid _userId;

        public EventService(Guid userId)
        {
            _userId = userId;
        }
        public EventService()
        {

        }
        public bool CreateEvent(EventCreateModel model)
        {
            var entity =
                new EventEntity
                {
                    OwnerId = _userId,
                    Name = model.Event,
                    Description = model.Description,
                    EventDate = model.EventDate,
                    CreatedUtc = DateTimeOffset.UtcNow
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Events.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteEvent(int quoteId)
        {
            throw new NotImplementedException();
        }

        public EventDetailsModel GetEventById(int eventId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventListModel> GetEvents()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent(EventEditModel model)
        {
            throw new NotImplementedException();
        }
    }
}
