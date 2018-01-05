using Microsoft.AspNet.Identity;
using PitchFeast.Models;
using PitchFeast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PitchFeast.WebApi.Controllers
{
    [Authorize]
    public class EventController : ApiController
    {
        // GET /api/note
        public IHttpActionResult GetAll()
        {
            var eventService = CreateEventService();
            var events = eventService.GetEvents();
            return Ok(events);
        }
        public IHttpActionResult Get(int id)
        {
            var eventService = CreateEventService();
            var individualEvent = eventService.GetEventById(id);
            return Ok(individualEvent);
        }

        public IHttpActionResult Post(EventCreateModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var service = CreateEventService();

            if (!service.CreateEvent(model))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(EventEditModel individualEvent)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateEventService();

            if (!service.UpdateEvent(individualEvent))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateEventService();

            if (!service.DeleteEvent(id))
                return InternalServerError();

            return Ok();
        }

        private EventService CreateEventService()
        {
            var eventId = Guid.Parse(User.Identity.GetUserId());
            var eventService = new EventService(eventId);
            return eventService;
        }

    }
}
