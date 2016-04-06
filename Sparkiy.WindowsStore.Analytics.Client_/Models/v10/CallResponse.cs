using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The API call response.
    /// </summary>
    /// <typeparam name="T">The type of data returned by the response.</typeparam>
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class CallResponse<T>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public IEnumerable<T> Value { get; set; }

        /// <summary>
        /// Gets or sets the next link.
        /// </summary>
        /// <value>
        /// The next link.
        /// </value>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        [JsonProperty("@nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or sets the total items count.
        /// </summary>
        /// <value>
        /// The total items count.
        /// </value>
        // ReSharper disable once UnusedMember.Global
        public int TotalCount { get; set; }
    }
}