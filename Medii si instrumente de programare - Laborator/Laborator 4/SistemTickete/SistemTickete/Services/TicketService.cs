using SistemTickete.Events;
using SistemTickete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemTickete.Delegates.Delegates;
using static SistemTickete.Models.Enum;

namespace SistemTickete.Services
{
    public class TicketService : TicketEventArgs
    {
        public event EventHandler<TicketEventArgs> TicketBooked;
        public event EventHandler<TicketEventArgs> TicketConfirmed;
        public event EventHandler<TicketEventArgs> TicketCancelled;
        public event EventHandler<Event> EventSoldOut;
        public event EventHandler<Event> LowAvailability;
        public event EventHandler<Event> TicketsAvailable;
        public event EventHandler<Event> ReviewPeriodOpened;

        public PriceCalculator PriceCalculator { get; set; }
        public TicketValidator TicketValidator { get; set; }
        public PaymentProcessor PaymentProcessor { get; set; }
        public RefundCalculator RefundCalculator { get; set; }

        private Dictionary<int, Queue<WaitingList>> waitingLists =  new Dictionary<int, Queue<WaitingList>>();

        private int ticketId = 1;

        public Ticket BookTicket(Event ev, Customer customer, int count, PaymentMethod method, bool vip = false)
        {
            if (!TicketValidator(ev, customer, count))
            {
                AddToWaitingList(ev, customer, count);
                throw new Exception("Bilete indisponibile – adaugat în waiting list");
            }

            decimal price = PriceCalculator(ev, customer, count, vip);

            if (!PaymentProcessor(price, method))
                throw new Exception("Plata esuata");

            ev.AvailableTickets -= count;

            var ticket = new Ticket
            {
                TicketId = ticketId++,
                EventId = ev.EventId,
                CustomerName = customer.Name,
                Price = price,
                PurchaseDate = DateTime.Now,
                Status = TicketStatus.Confirmed,
                IsVIP = vip
            };

            TicketBooked?.Invoke(this, new TicketEventArgs { Ticket = ticket, Event = ev, Amount = price });
            TicketConfirmed?.Invoke(this, new TicketEventArgs { Ticket = ticket, Event = ev, Amount = price });

            if (ev.AvailableTickets == 0)
                EventSoldOut?.Invoke(this, ev);
            else if (ev.AvailableTickets < 10)
                LowAvailability?.Invoke(this, ev);

            return ticket;
        }

        public decimal CancelTicket(Ticket ticket, Event ev)
        {
            ticket.Status = TicketStatus.Cancelled;
            ev.AvailableTickets++;

            decimal refund = RefundCalculator(ticket, ev);
            TicketCancelled?.Invoke(this, new TicketEventArgs { Ticket = ticket, Event = ev, Amount = refund });

            TicketsAvailable?.Invoke(this, ev);
            return refund;
        }

        public void AddToWaitingList(Event ev, Customer customer, int count)
        {
            if (!waitingLists.ContainsKey(ev.EventId))
                waitingLists[ev.EventId] = new Queue<WaitingList>();

            waitingLists[ev.EventId].Enqueue(new WaitingList
            {
                Customer = customer,
                RequestedTickets = count,
                RequestDate = DateTime.Now
            });
        }

        public bool TransferTicket(Ticket ticket, Customer to)
        {
            if (ticket.Status != TicketStatus.Confirmed) return false;
            ticket.CustomerName = to.Name;
            return true;
        }

        public void OpenReview(Event ev)
        {
            ReviewPeriodOpened?.Invoke(this, ev);
        }
    }
}
