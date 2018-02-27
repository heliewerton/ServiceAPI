using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.Infrastructure
{
    public static class Settings
    {

        public static string TRAVELLOGIC_ENDPOINT = System.Configuration.ConfigurationSettings.AppSettings["TravelLogic.Endpoint"];

        public static string TRAVELLOGIC_AUTH_ERROR_MSG = System.Configuration.ConfigurationSettings.AppSettings["TravelLogig.NotAuthenticated.Message"];

        public static string TRAVELLOGIC_API_LOGIN = System.Configuration.ConfigurationSettings.AppSettings["API_LOGIN"];

        public static string TRAVELLOGIC_API_PWD = System.Configuration.ConfigurationSettings.AppSettings["API_PWD"];

        public static string TRAVELLOGIC_SEARCH_URI = System.Configuration.ConfigurationSettings.AppSettings["TravelLogic.Search.URI"];

        public static string TRAVELLOGIC_TOKEN_URI = System.Configuration.ConfigurationSettings.AppSettings["TravelLogic.Token.URI"];

    }
}
