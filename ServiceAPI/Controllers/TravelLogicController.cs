using ServiceAPI.Library.TravelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceAPI.Controllers
{
    [RoutePrefix("api/travellogic")]
    public class TravelLogicController : ApiController
    {

        private ITravelLogicService _travelLogicService;

        public TravelLogicController(ITravelLogicService travelLogicService)
        {
            _travelLogicService = travelLogicService;
        }
        /// <summary>
        /// This method will call the Travel Logic api and it will return the result for a basic search.
        /// </summary>
        /// <returns></returns>
        [Route("search")]
        public IHttpActionResult Search()
        {
            // The Json object to be sent to the client
            object result = null;

            try
            {
                // Calls the Travel Logic search method
                result = _travelLogicService.Search();
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(result);
        }
    }
}
