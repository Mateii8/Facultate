using SistemTickete.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Services
{
    public class InventoryManager
    {
        public void OnTicketConfirmed(object sender, TicketEventArgs e)
        {
            Console.WriteLine($" INVENTORY: Stoc actualizat pentru evenimentul {e.Event.Name}");
        }

        public void OnTicketsAvailable(object sender, Models.Event ev)
        {
            Console.WriteLine($"INVENTORY: Bilete eliberate pentru {ev.Name}");
        }
    }
}
