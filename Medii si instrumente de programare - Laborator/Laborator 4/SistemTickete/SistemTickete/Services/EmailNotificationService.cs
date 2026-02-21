using SistemTickete.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Services
{
  public class EmailNotificationService : TicketEventArgs
    {

        public void OnTicketBooked(object sender, TicketEventArgs e)
        {
            Console.WriteLine($"EMAIL: Bilet rezervat pentru {e.Ticket.CustomerName}");
        }

        public void OnTicketConfirmed(object sender, TicketEventArgs e)
        {
            Console.WriteLine($"EMAIL: Plata confirmata. Suma: {e.Amount} RON");
        }

        public void OnTicketCancelled(object sender, TicketEventArgs e)
        {
            Console.WriteLine($" EMAIL: Bilet anulat. Refund: {e.Amount} RON");
        }
    }
}
