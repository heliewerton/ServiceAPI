using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic.Model
{
    public class Ticket
    {
        public string AvailToken { get; set; }
        public TicketInfo TicketInfo { get; set; }
        public string ImageThumb { get; set; }
        public string ImageFull { get; set; }
        public List<AvailableModality> AvailableModality { get; set; }
    }
}
