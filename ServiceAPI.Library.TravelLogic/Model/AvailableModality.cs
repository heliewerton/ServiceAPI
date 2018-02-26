using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic.Model
{
    public class AvailableModality
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Contract Contract { get; set; }
        public decimal ServicePrice { get; set; }
        public List<OperationDate> OperationDateList { get; set; }    

    }
}
