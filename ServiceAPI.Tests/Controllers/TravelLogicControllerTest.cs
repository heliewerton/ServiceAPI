using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceAPI;
using ServiceAPI.Controllers;
using ServiceAPI.Library.TravelLogic;

namespace ServiceAPI.Tests.Controllers
{
    [TestClass]
    public class TravelLogicControllerTest
    {
        [TestMethod]
        public void Search()
        {
            // Arrange
            TravelLogicController controller = new TravelLogicController(new TravelLogicService());

            // Act
            object result = controller.Search();

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
