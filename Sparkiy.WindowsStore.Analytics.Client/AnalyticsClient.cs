using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sparkiy.WindowsStore.Analytics.Client
{
    /// <summary>
    /// The Windows Store Analytics API client.
    /// </summary>
    /// <seealso cref="System.Net.Http.HttpClient" />
    public class AnalyticsClient : HttpClient
    {
        // Token
        private const string TokenRequestUrl = "https://login.microsoftonline.com/7ceea2c9-b524-40e0-bf30-02f1ffb15c4f/oauth2/token";
        private AzureADTokenResponse token;


        /// <summary>
        /// Authorizes the client.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <exception cref="AnalyticsClientInvalidClientDataException">The provided client identifier is invalid. See exception message for more details.</exception>
        /// <exception cref="AnalyticsClientUnauthorizedException">The provided client secret is invalid. See exception message for more details.</exception>
        /// <exception cref="AnalyticsClientException">Server returned error. See exception message for more details.</exception>
        public async Task AuthorizeAsync(string clientId, string clientSecret)
        {
            using (var tokenClient = new HttpClient())
            {
                // Send request for token
                using (var response = await tokenClient.PostAsync(TokenRequestUrl,
                        new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("grant_type", "client_credentials"),
                            new KeyValuePair<string, string>("client_id", clientId),
                            new KeyValuePair<string, string>("client_secret", clientSecret),
                            new KeyValuePair<string, string>("resource",
                                "https://manage.devcenter.microsoft.com")
                        })))
                {

                    // Read response content string
                    string responseString = null;
                    try
                    {
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                    catch (Exception)
                    {
                        // Failed to read response content, ignore error
                    }


                    // Handle errors
                    if (!response.IsSuccessStatusCode || responseString == null)
                    {
                        // ReSharper disable once SwitchStatementMissingSomeCases
                        switch (response.StatusCode)
                        {
                            case HttpStatusCode.BadRequest:
                                throw new AnalyticsClientInvalidClientDataException(responseString);
                            case HttpStatusCode.Unauthorized:
                                throw new AnalyticsClientUnauthorizedException(responseString);
                            default:
                                throw new AnalyticsClientException(responseString);
                        }
                    }

                    // Deserialize token
                    this.token = JsonConvert.DeserializeObject<AzureADTokenResponse>(responseString);
                }
            }
        }

        /// <summary>
        /// Calls the GET action of analytics API.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Returns the raw content string - the response from the API.</returns>
        /// <exception cref="AnalyticsClientInvalidRequestDataException">The request query is invalid. See exception message for more details.</exception>
        /// <exception cref="AnalyticsClientUnauthorizedException">The client token has expired. See exception message for more details.</exception>
        /// <exception cref="AnalyticsClientException">Server returned error. See exception message for more details.</exception>
        internal async Task<string> CallGetAnalyticsApiAsync(string requestUri)
        {
            // Create GET request and add authorization header
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this.token.access_token);

            // Instantiate HTTP client
            using (var httpClient = new HttpClient())
            {
                // Send request and process the response
                using (var response = await httpClient.SendAsync(requestMessage))
                {
                    // Read response content string
                    string responseString = null;
                    try
                    {
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                    catch (Exception)
                    {
                        // Failed to read response content, ignore error
                    }

                    // If response return 200(OK), return the response content string
                    if (response.IsSuccessStatusCode)
                        return responseString;

                    // ReSharper disable once SwitchStatementMissingSomeCases
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.BadRequest:
                            throw new AnalyticsClientInvalidRequestDataException($"GET: {requestUri} \n{responseString}");
                        case HttpStatusCode.Unauthorized:
                            throw new AnalyticsClientUnauthorizedException($"GET: {requestUri} \n{responseString}");
                        default:
                            throw new AnalyticsClientException($"GET: {requestUri} \n{responseString}");
                    }
                }
            }
        }
    }
}
