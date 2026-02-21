using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Services
{
    public class SMSNotificationService
    {
        public void OnLowAvailability(object sender, Models.Event ev)
        {
            Console.WriteLine($"SMS: Atentie! Putine bilete ramase la {ev.Name}");
        }

        public void OnSoldOut(object sender, Models.Event ev)
        {
            Console.WriteLine($"SMS: Eveniment SOLD OUT – {ev.Name}");
        }
    }
}
