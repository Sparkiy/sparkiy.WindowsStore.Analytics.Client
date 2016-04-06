using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The Windows Store Analytics v1.0 client extensions.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    public static class AnalyticsClientExtensions
    {
        private const string AnalyticsV10CallUrlBase = "https://manage.devcenter.microsoft.com/v1.0/my/analytics/";
        private const string AnalyticsV10CallUrl =
            AnalyticsV10CallUrlBase + "{0}?applicationId={1}&startDate={2}&endDate={3}&top={4}&skip={5}";

        /// <summary>
        /// Gets the analytics call URL.
        /// </summary>
        /// <param name="call">The call.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The top.</param>
        /// <param name="skip">The skip.</param>
        /// <returns>Returns the analytics URL.</returns>
        private static string GetAnalyticsCallUrl(SupportedCalls call, string appId, DateTime startDate, DateTime endDate, int top, int skip)
        {
            return string.Format(AnalyticsV10CallUrl, call, appId, startDate, endDate, top, skip);
        }

        /// <summary>
        /// Gets the analytics call next page URL.
        /// </summary>
        /// <param name="nextLink">The next link.</param>
        /// <returns>Returns URL to the next page call.</returns>
        private static string GetAnalyticsCallUrlNextPage(string nextLink)
        {
            return $"{AnalyticsV10CallUrlBase}{nextLink}";
        }

        /// <summary>
        /// Gets the analytics call results.
        /// </summary>
        /// <typeparam name="T">The type of data that is acquired from API.</typeparam>
        /// <param name="client">The client.</param>
        /// <param name="call">The call.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The top.</param>
        /// <param name="skip">The skip.</param>
        /// <param name="fetchAll">If set to <c>True</c> all items will be fetched - this will effectively override paging.</param>
        /// <returns>Returns full collection of requested data.</returns>
        private static async Task<IEnumerable<T>> GetAnalyticsCallResultsAsync<T>(AnalyticsClient client, SupportedCalls call, string appId, DateTime startDate, DateTime endDate, int top, int skip, bool fetchAll = false)
        {
            var results = new List<T>();
            var requestUri = GetAnalyticsCallUrl(call, appId, startDate, endDate, top, skip);
            CallResponse<T> data;
            do
            {
                var dataRaw = await client.CallGetAnalyticsApiAsync(requestUri);
                data = JsonConvert.DeserializeObject<CallResponse<T>>(dataRaw);
                results.AddRange(data.Value);

                if (!string.IsNullOrEmpty(data.NextLink))
                    requestUri = GetAnalyticsCallUrlNextPage(data.NextLink);

            } while (fetchAll && !string.IsNullOrEmpty(data.NextLink));

            return results;
        }

        /// <summary>
        /// Gets the application acquisitions.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The top.</param>
        /// <param name="skip">The skip.</param>
        /// <param name="fetchAll">If set to <c>True</c> all items will be fetched - this will effectively override paging.</param>
        /// <returns>Returns the collection of <see cref="AppAcquisition"/>.</returns>
        public static async Task<IEnumerable<AppAcquisition>> GetAppAcquisitionsAsync(this AnalyticsClient client, string appId, DateTime startDate, DateTime endDate, int top, int skip, bool fetchAll = false)
        {
            return await GetAnalyticsCallResultsAsync<AppAcquisition>(
                client, SupportedCalls.appacquisitions, 
                appId, startDate, endDate, top, skip, fetchAll);
        }

        /// <summary>
        /// Gets the IAP acquisitions.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The number of top items to take.</param>
        /// <param name="skip">The number of items to skip.</param>
        /// <param name="fetchAll">If set to <c>True</c> all items will be fetched - this will effectively override paging.</param>
        /// <returns>Returns the collection of <see cref="AppIapAcquisition"/>.</returns>
        public static async Task<IEnumerable<AppIapAcquisition>> GetIapAcquisitionsAsync(this AnalyticsClient client, string appId, DateTime startDate, DateTime endDate, int top, int skip, bool fetchAll = false)
        {
            return await GetAnalyticsCallResultsAsync<AppIapAcquisition>(
                client, SupportedCalls.inappacquisitions,
                appId, startDate, endDate, top, skip, fetchAll);
        }

        /// <summary>
        /// Gets the application failure hits.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The number of top items to take.</param>
        /// <param name="skip">The number of items to skip.</param>
        /// <param name="fetchAll">If set to <c>True</c> all items will be fetched - this will effectively override paging.</param>
        /// <returns>Returns the collection of <see cref="AppFailureHit"/>.</returns>
        public static async Task<IEnumerable<AppFailureHit>> GetAppFailureHitsAsync(this AnalyticsClient client, string appId, DateTime startDate, DateTime endDate, int top, int skip, bool fetchAll = false)
        {
            return await GetAnalyticsCallResultsAsync<AppFailureHit>(
                client, SupportedCalls.failurehits,
                appId, startDate, endDate, top, skip, fetchAll);
        }

        /// <summary>
        /// Gets the application ratings.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The number of top items to take.</param>
        /// <param name="skip">The number of items to skip.</param>
        /// <param name="fetchAll">If set to <c>True</c> all items will be fetched - this will effectively override paging.</param>
        /// <returns>Returns the collection of <see cref="AppRating"/>.</returns>
        public static async Task<IEnumerable<AppRating>> GetAppRatingsAsync(this AnalyticsClient client, string appId, DateTime startDate, DateTime endDate, int top, int skip, bool fetchAll = false)
        {
            return await GetAnalyticsCallResultsAsync<AppRating>(
                client, SupportedCalls.ratings,
                appId, startDate, endDate, top, skip, fetchAll);
        }

        /// <summary>
        /// Gets the application reviews.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="appId">The application identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="top">The number of top items to take.</param>
        /// <param name="skip">The number of items to skip.</param>
        /// <param name="fetchAll">If set to <c>True</c> all items will be fetched - this will effectively override paging.</param>
        /// <returns>Returns the collection of <see cref="AppReview"/>.</returns>
        public static async Task<IEnumerable<AppReview>> GetAppReviewsAsync(this AnalyticsClient client, string appId, DateTime startDate, DateTime endDate, int top, int skip, bool fetchAll = false)
        {
            return await GetAnalyticsCallResultsAsync<AppReview>(
                client, SupportedCalls.reviews,
                appId, startDate, endDate, top, skip, fetchAll);
        }
    }
}