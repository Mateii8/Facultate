using SistemTickete.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Services
{
    public class AdminDashboard
    {
        public int TicketsSold { get; private set; }
        public int TicketsCancelled { get; private set; }
        public decimal Revenue { get; private set; }

        public void OnConfirmed(object sender, TicketEventArgs e)
        {
            TicketsSold++;
            Revenue += e.Amount;
            Print();
        }

        public void OnCancelled(object sender, TicketEventArgs e)
        {
            TicketsCancelled++;
            Revenue -= e.Amount;
            Print();
        }

        private void Print()
        {
            Console.WriteLine(" DASHBOARD ADMIN");
            Console.WriteLine($"   Vandute: {TicketsSold}");
            Console.WriteLine($"    Anulate: {TicketsCancelled}");
            Console.WriteLine($"   Venit: {Revenue} RON");
        }
    }
}
