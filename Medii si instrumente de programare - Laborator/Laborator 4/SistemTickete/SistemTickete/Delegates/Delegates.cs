using SistemTickete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemTickete.Models.Enum;

namespace SistemTickete.Delegates
{
    public class Delegates
    {
        public delegate decimal PriceCalculator(Event ev, Customer customer, int count, bool vip);
        public delegate bool TicketValidator(Event ev, Customer customer, int count);
        public delegate bool PaymentProcessor(decimal amount, PaymentMethod method);
        public delegate decimal RefundCalculator(Ticket ticket, Event ev);
    }
}
