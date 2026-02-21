using SistemTickete.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace SistemTickete.Services
{
    public class TransactionLogger
    {
        private const string FileName = "transactions.json";

        public void OnTicketEvent(object sender, TicketEventArgs e)
        {
            var json = JsonSerializer.Serialize(e, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.AppendAllText(FileName, json + System.Environment.NewLine);
        }
    }
}
