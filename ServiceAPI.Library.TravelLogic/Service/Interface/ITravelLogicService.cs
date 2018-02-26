using ServiceAPI.Library.TravelLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic
{
    public interface ITravelLogicService
    {
        /// <summary>
        /// Calss the Travel Logic api to retrieve the search result.
        /// </summary>
        /// <returns></returns>
        object Search(TravelLogicSearch inputSearch);
        /// <summary>
        /// Gets a token to access the Travel Logic api.
        /// </summary>
        /// <returns></returns>
        TokenResult Authenticate();
    }
}
