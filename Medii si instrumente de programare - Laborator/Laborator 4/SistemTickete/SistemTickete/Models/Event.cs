using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemTickete.Models.Enum;

namespace SistemTickete.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public int AvailableTickets { get; set; }
        public decimal TicketPrice { get; set; }
        public EventCategory Category { get; set; }
    }
}
