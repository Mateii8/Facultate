using SistemTickete.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Services
{
    public class RevenueTracker
    {
        public decimal TotalRevenue { get; private set; }

        public void OnTicketConfirmed(object sender, TicketEventArgs e)
        {
            TotalRevenue += e.Amount;
            Console.WriteLine($"REVENUE: Total = {TotalRevenue} RON");
        }

        public void OnTicketCancelled(object sender, TicketEventArgs e)
        {
            TotalRevenue -= e.Amount;
            Console.WriteLine($"REVENUE: Refund aplicat. Total = {TotalRevenue} RON");
        }
    }
}
