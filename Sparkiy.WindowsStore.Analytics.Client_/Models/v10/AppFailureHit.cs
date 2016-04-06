using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The application failure hit.
    /// </summary>
    /// <seealso cref="Sparkiy.WindowsStore.Analytics.Client.Models.v10.AppAnalyticsItem" />
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AppFailureHit : AppAnalyticsItem
    {
        /// <summary>
        /// Gets or sets the name of the failure.
        /// </summary>
        /// <value>
        /// The name of the error.
        /// </value>
        public string FailureName { get; set; }

        /// <summary>
        /// Gets or sets the failure hash.
        /// </summary>
        /// <value>
        /// The unique identifier for the error.
        /// </value>
        public string FailureHash { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol assigned to this error.
        /// </value>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>
        /// The type of error event.
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - crash
        ///  - hang
        ///  - memory
        ///  - jse
        /// 
        /// </remarks>
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the name of the package.
        /// </summary>
        /// <value>
        /// The unique name of the app package that is associated with this error.
        /// </value>
        public string PackageName { get; set; }

        /// <summary>
        /// Gets or sets the package version.
        /// </summary>
        /// <value>
        /// The version of the app package that is associated with this error.
        /// </value>
        public string PackageVersion { get; set; }

        /// <summary>
        /// Gets or sets the device count.
        /// </summary>
        /// <value>
        /// The number of unique devices that correspond to this error for the specified aggregation level.
        /// </value>
        public string DeviceCount { get; set; }

        /// <summary>
        /// Gets or sets the event count.
        /// </summary>
        /// <value>
        /// The number of events that are attributed to this error for the specified aggregation level.
        /// </value>
        public string EventCount { get; set; }
    }
}