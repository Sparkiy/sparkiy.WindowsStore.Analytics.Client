using System;
using System.Linq;
using Sparkiy.WindowsStore.Analytics.Client;
using Sparkiy.WindowsStore.Analytics.Client.Models.v10;

namespace StoreApiTest
{
    class Program
    {
        private const string ClientId = "<YOUR CLIENT ID>";
        private const string ClientSecret = "<YOUR CLIENT SECRET>";
        private const string AppId = "<YOUR APP ID>";

        static void Main(string[] args)
        {
            Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static async void Run()
        {
            // Instantiate new analytics client
            using (var client = new AnalyticsClient())
            {
                // Authorize using client identifier and secret
                try
                {
                    await client.AuthorizeAsync(ClientId, ClientSecret);
                }
                catch (AnalyticsClientInvalidClientDataException)
                {
                    Console.WriteLine("Client Id is invalid.");
                }
                catch (AnalyticsClientUnauthorizedException)
                {
                    Console.WriteLine("Client Secret is invalid.");
                }

                // Query fields
                var appID = AppId;
                var startDate = DateTime.Parse("01-01-2016");
                var endDate = DateTime.Parse("31-12-2016");
                var pageSize = 100;
                var startPageIndex = 0;

                // Retrieve data from API
                try
                {
                    var result = await client.GetAppAcquisitionsAsync(
                        appID, startDate, endDate, pageSize, startPageIndex);

                    Console.WriteLine("Got {0} acquisitions.", result.Count());
                }
                catch (AnalyticsClientInvalidRequestDataException)
                {
                    Console.WriteLine("Provided query field(s) are invalid.");
                }
            }
        }
    }
}
