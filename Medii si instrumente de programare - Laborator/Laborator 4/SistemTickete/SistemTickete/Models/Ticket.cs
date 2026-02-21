using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemTickete.Models.Enum;

namespace SistemTickete.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public string CustomerName { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TicketStatus Status { get; set; }
        public bool IsVIP { get; set; }
    }
}
