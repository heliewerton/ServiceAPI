using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic.Model
{
    /// <summary>
    /// The class that represents the JSON returned by the Travel Logic api
    /// </summary>
    public class TravelLogicSearchResult
    {
        public List<Ticket> Result { get; set; }
    }
}
