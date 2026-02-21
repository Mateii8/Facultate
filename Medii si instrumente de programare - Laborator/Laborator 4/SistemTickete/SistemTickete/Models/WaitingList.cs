using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTickete.Models
{
    public class WaitingList
    {
        public Customer Customer { get; set; }
        public int RequestedTickets { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
