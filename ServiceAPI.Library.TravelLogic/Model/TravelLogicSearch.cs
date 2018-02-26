using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic.Model
{
    /// <summary>
    /// The class that represts the travel logic api request body
    /// </summary>
    public class TravelLogicSearch
    {
        public string Language { get; set; }

        public string Currency { get; set; }

        public string Destination { get; set; }

        public string DateFrom { get; set; }
        public string DateTo { get; set; }

        public Occupancy Occupancy { get; set; }

        /// <summary>
        /// Creates a test object to use in demo requests
        /// </summary>
        /// <returns></returns>
        public static TravelLogicSearch GetDemoObject()
        {
            var searchObject = new TravelLogicSearch();
            searchObject.Currency = "USD";
            searchObject.Language = "ENG";
            searchObject.Destination = "MCO";
            searchObject.DateFrom = "11/26/2018";
            searchObject.DateTo = "11/29/2018";
            searchObject.Occupancy = new Occupancy() {
                AdultCount = 1, ChildCount = 1, ChildAges = new int[1] { 10 }
            };

            return searchObject;
        }
    }
}
