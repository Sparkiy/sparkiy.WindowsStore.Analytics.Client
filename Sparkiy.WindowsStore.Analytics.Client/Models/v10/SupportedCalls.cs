using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The supported calls.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal enum SupportedCalls
    {
        /// <summary>
        /// The App Acquisitions.
        /// </summary>
        appacquisitions,

        /// <summary>
        /// The In-App Acquisitions.
        /// </summary>
        inappacquisitions,

        /// <summary>
        /// The Failure Hits.
        /// </summary>
        failurehits,

        /// <summary>
        /// The Ratings.
        /// </summary>
        ratings,

        /// <summary>
        /// The Reviews.
        /// </summary>
        reviews
    }
}