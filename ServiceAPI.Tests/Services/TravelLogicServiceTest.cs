using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceAPI.Library.TravelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Tests.Services
{
    [TestClass]
    public class TravelLogicServiceTest
    {
        [TestMethod]
        public void Authenticate()
        {
            // Arrange
            ITravelLogicService travelLogicService = new TravelLogicService();
            // Call the service
            var authToken = travelLogicService.Authenticate();
            // Verify
            Assert.IsTrue(authToken.IsAuthenticated());

        }

        [TestMethod]
        public void Search()
        {
            // Arrange
            ITravelLogicService travelLogicService = new TravelLogicService();
            // Call the service
            var searchResult = travelLogicService.Search();
            // Verify
            Assert.IsNotNull(searchResult);

        }
    }
}
