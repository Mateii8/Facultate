using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Models
{
    public class Enum
    {
        public enum EventCategory { Concert, Theater, Sports, Conference }
        public enum TicketStatus { Reserved, Confirmed, Cancelled }
        public enum MembershipLevel { Regular, Silver, Gold, Platinum }
        public enum PaymentMethod { Card, Cash }
    }
}
