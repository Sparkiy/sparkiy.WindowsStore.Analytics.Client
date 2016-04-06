using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The application in-app-purchase acquisition.
    /// </summary>
    /// <seealso cref="Sparkiy.WindowsStore.Analytics.Client.Models.v10.AppAnalyticsItemAcquisition" />
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AppIapAcquisition : AppAnalyticsItemAcquisition
    {
        /// <summary>
        /// Gets or sets the in application product identifier.
        /// </summary>
        /// <value>
        /// The product ID of the IAP for which you are retrieving acquisition data.
        /// </value>
        public string InAppProductId { get; set; }

        /// <summary>
        /// Gets or sets the name of the in application product.
        /// </summary>
        /// <value>
        /// The display name of the IAP.
        /// </value>
        public string InAppProductName { get; set; }
    }
}