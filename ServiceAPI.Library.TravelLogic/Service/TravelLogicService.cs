using Newtonsoft.Json;
using ServiceAPI.Library.TravelLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Library.TravelLogic
{
    public class TravelLogicService : ITravelLogicService
    {
        private static string endpoint = ServiceAPI.Library.Infrastructure.Settings.TRAVELLOGIC_ENDPOINT;

        public TokenResult Authenticate()
        {
            var result = new TokenResult();

            try
            {
                string tokenURI = ServiceAPI.Library.Infrastructure.Settings.TRAVELLOGIC_TOKEN_URI;

                // Create the HTTP client and set the API URL on it
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);

                // Set the API login attributes
                string urlParameters = string.Format("grant_type=password&username={0}&password={1}",
                    ServiceAPI.Library.Infrastructure.Settings.TRAVELLOGIC_API_LOGIN, ServiceAPI.Library.Infrastructure.Settings.TRAVELLOGIC_API_PWD);


                // Gets the content
                var content = new StringContent(urlParameters, Encoding.Default);

                // Api data response
                HttpResponseMessage response = client.PostAsync(tokenURI, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body
                    result = JsonConvert.DeserializeObject<TokenResult>(response.Content.ReadAsStringAsync().Result);

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public object Search(TravelLogicSearch inputSearch)
        {
            object result = null;
            string searchURI = ServiceAPI.Library.Infrastructure.Settings.TRAVELLOGIC_SEARCH_URI;

            try
            {

                // Create the HTTP client and set the API URL on it
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


                // Get the token 
                var token = Authenticate();

                if (token.IsAuthenticated())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.access_token);
                }
                else
                {
                    throw new Exception(ServiceAPI.Library.Infrastructure.Settings.TRAVELLOGIC_AUTH_ERROR_MSG);
                }

                // The http body request
                var content = new StringContent(JsonConvert.SerializeObject(inputSearch), Encoding.UTF8, "application/json");

                // List data response
                HttpResponseMessage response = client.PostAsync(searchURI, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body to get the list of tickets
                    var responseParsed = JsonConvert.DeserializeObject<TravelLogicSearchResult>(response.Content.ReadAsStringAsync().Result);
                    result = responseParsed.Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
