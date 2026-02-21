using SistemTickete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Events
{
    public class TicketEventArgs : EventArgs
    {
        public Ticket Ticket { get; set; }
        public Event Event { get; set; }
        public decimal Amount { get; set; }
    }
}
