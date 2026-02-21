using SistemTickete.Events;
using SistemTickete.Models;
using SistemTickete.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemTickete.Models.Enum;

namespace SistemTickete
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Event ev = new Event
            {
                EventId = 1,
                Name = "Concert Rock",
                Date = DateTime.Now.AddDays(20),
                Venue = "Arena Nationala",
                AvailableTickets = 5,
                TicketPrice = 200,
                Category = EventCategory.Concert
            };

     
            Customer customer1 = new Customer
            {
                CustomerId = 1,
                Name = "Alex",
                Email = "alex@test.com",
                Phone = "0711111111",
                MembershipLevel = MembershipLevel.Gold
            };

            Customer customer2 = new Customer
            {
                CustomerId = 2,
                Name = "Maria",
                Email = "maria@test.com",
                Phone = "0722222222",
                MembershipLevel = MembershipLevel.Regular
            };

            TicketService service = new TicketService();

            EmailNotificationService email = new EmailNotificationService();
            SMSNotificationService sms = new SMSNotificationService();
            InventoryManager inventory = new InventoryManager();
            RevenueTracker revenue = new RevenueTracker();
            AdminDashboard dashboard = new AdminDashboard();
            TransactionLogger logger = new TransactionLogger();

          
            service.TicketBooked += email.OnTicketBooked;
            service.TicketConfirmed += email.OnTicketConfirmed;
            service.TicketCancelled += email.OnTicketCancelled;

            service.LowAvailability += sms.OnLowAvailability;
            service.EventSoldOut += sms.OnSoldOut;

            service.TicketConfirmed += inventory.OnTicketConfirmed;
            service.TicketsAvailable += inventory.OnTicketsAvailable;

            service.TicketConfirmed += revenue.OnTicketConfirmed;
            service.TicketCancelled += revenue.OnTicketCancelled;

            service.TicketConfirmed += dashboard.OnConfirmed;
            service.TicketCancelled += dashboard.OnCancelled;

            service.TicketConfirmed += logger.OnTicketEvent;
            service.TicketCancelled += logger.OnTicketEvent;

         
            service.TicketValidator = delegate (Event e, Customer c, int count)
            {
                return e.Date > DateTime.Now && e.AvailableTickets >= count;
            };

            service.PriceCalculator = delegate (Event e, Customer c, int count, bool vip)
            {
                decimal price = e.TicketPrice * count;

                if (c.MembershipLevel == MembershipLevel.Silver)
                    price *= 0.95m;
                else if (c.MembershipLevel == MembershipLevel.Gold)
                    price *= 0.90m;
                else if (c.MembershipLevel == MembershipLevel.Platinum)
                    price *= 0.85m;

                if ((e.Date - DateTime.Now).TotalDays > 14)
                    price *= 0.90m;

                if (count >= 5)
                    price *= 0.93m;

                if (vip)
                    price += 100;

                return price;
            };

           
            service.PaymentProcessor = delegate (decimal amount, PaymentMethod method)
            {
                Console.WriteLine("Plata efectuata prin " + method + ": " + amount + " RON");
                return true;
            };

           
            service.RefundCalculator = delegate (Ticket t, Event e)
            {
                double daysLeft = (e.Date - DateTime.Now).TotalDays;

                if (daysLeft > 14) return t.Price;
                if (daysLeft > 7) return t.Price * 0.5m;
                return 0;
            };

         
            try
            {
                Console.WriteLine("\n=== REZERVARE BILET VIP ===");
                Ticket ticket1 = service.BookTicket(ev, customer1, 2, PaymentMethod.Card, true);

                Console.WriteLine("\n=== ANULARE + REFUND ===");
                decimal refund = service.CancelTicket(ticket1, ev);
                Console.WriteLine("Refund primit: " + refund + " RON");

                Console.WriteLine("\n=== INCERCARE REZERVARE (WAITING LIST) ===");
                service.BookTicket(ev, customer2, 5, PaymentMethod.Cash, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" " + ex.Message);
            }

            Console.WriteLine("\n=== TRANSFER BILET ===");
            Ticket transferTicket = service.BookTicket(ev, customer1, 1, PaymentMethod.Card, false);
            bool transferred = service.TransferTicket(transferTicket, customer2);
            Console.WriteLine("Transfer reusit: " + transferred);

            Console.WriteLine("\n=== DESCHIDERE REVIEW ===");
            service.OpenReview(ev);

            Console.WriteLine("\nApasa orice tasta...");
            Console.ReadKey();
        }
    }
}
