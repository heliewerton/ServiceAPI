using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic.Model
{
    public class Occupancy
    {
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int[] ChildAges { get; set; }
    }
}
