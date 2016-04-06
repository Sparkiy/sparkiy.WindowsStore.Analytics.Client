using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The application analytics item with acquisition fields.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class AppAnalyticsItemAcquisition : AppAnalyticsItem
    {
        /// <summary>
        /// Gets or sets the name of the order.
        /// </summary>
        /// <value>
        /// The name of the order.
        /// </value>
        public string OrderName { get; set; }

        /// <summary>
        /// Gets or sets the store client.
        /// </summary>
        /// <value>
        /// The version of the Store where the acquisition occurred.
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - Windows Phone Store (client)
        ///  - Windows Store(client)
        ///  - Windows Store(web)
        ///  - Volume purchase by organizations
        ///  - Other
        /// 
        /// </remarks>
        public string StoreClient { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender of the user who made the acquisition.
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - m
        ///  - f
        ///  - Unknown
        /// 
        /// </remarks>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the age group.
        /// </summary>
        /// <value>
        /// The age group of the user who made the acquisition. 
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - less than 13
        ///  - 13-17
        ///  - 18-24
        ///  - 25-34
        ///  - 35-44
        ///  - 44-55
        ///  - greater than 55
        ///  - Unknown
        /// 
        /// </remarks>
        public string AgeGroup { get; set; }

        /// <summary>
        /// Gets or sets the type of the acquisition.
        /// </summary>
        /// <value>
        /// The type of acquisition (free, paid, and so on).
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - free
        ///  - trial
        ///  - paid
        ///  - promotional code
        ///  - iap
        /// 
        /// </remarks>
        public string AcquisitionType { get; set; }

        /// <summary>
        /// Gets or sets the acquisition quantity.
        /// </summary>
        /// <value>
        /// The number of acquisitions that occurred during the specified aggregation level.
        /// </value>
        public int AcquisitionQuantity { get; set; }
    }
}