using System;
using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The application review.
    /// </summary>
    /// <seealso cref="Sparkiy.WindowsStore.Analytics.Client.Models.v10.AppAnalyticsItem" />
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AppReview : AppAnalyticsItem
    {
        /// <summary>
        /// Gets or sets the is revised.
        /// </summary>
        /// <value>
        /// The value true indicates that the review was revised; otherwise false.
        /// </value>
        public string IsRevised { get; set; }

        /// <summary>
        /// Gets or sets the package version.
        /// </summary>
        /// <value>
        /// The version of the app package that was reviewed.
        /// </value>
        public string PackageVersion { get; set; }

        /// <summary>
        /// Gets or sets the device model.
        /// </summary>
        /// <value>
        /// The type of device on which the app was reviewed.
        /// </value>
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or sets the product family.
        /// </summary>
        /// <value>
        /// The device family name.
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - PC
        ///  - Tablet
        ///  - Phone
        ///  - Wearable
        ///  - Server
        ///  - Collaborative
        ///  - Other
        /// 
        /// </remarks>
        public string ProductFamily { get; set; }

        /// <summary>
        /// Gets or sets the device ram.
        /// </summary>
        /// <value>
        /// The physical RAM, in MB.
        /// </value>
        public int DeviceRAM { get; set; }

        /// <summary>
        /// Gets or sets the device screen resolution.
        /// </summary>
        /// <value>
        /// The device screen resolution in the format "width x height".
        /// </value>
        public string DeviceScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the device storage capacity.
        /// </summary>
        /// <value>
        /// The capacity of the primary storage disk, in GB.
        /// </value>
        public int DeviceStorageCapacity { get; set; }

        /// <summary>
        /// Gets or sets the is touch enabled.
        /// </summary>
        /// <value>
        /// The value true indicates that touch is enabled; otherwise false.
        /// </value>
        public string IsTouchEnabled { get; set; }

        /// <summary>
        /// Gets or sets the name of the reviewer.
        /// </summary>
        /// <value>
        /// The name of the reviewer.
        /// </value>
        public string ReviewerName { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The app rating, in stars.
        /// </value>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the review title.
        /// </summary>
        /// <value>
        /// The title of the review.
        /// </value>
        public string ReviewTitle { get; set; }

        /// <summary>
        /// Gets or sets the review text.
        /// </summary>
        /// <value>
        /// The text contents of the review.
        /// </value>
        public string ReviewText { get; set; }

        /// <summary>
        /// Gets or sets the helpful count.
        /// </summary>
        /// <value>
        /// The number of times the review was marked helpful.
        /// </value>
        public int HelpfulCount { get; set; }

        /// <summary>
        /// Gets or sets the not helpful count.
        /// </summary>
        /// <value>
        /// The number of times the review was marked not helpful.
        /// </value>
        public int NotHelpfulCount { get; set; }

        /// <summary>
        /// Gets or sets the response date.
        /// </summary>
        /// <value>
        /// The date a response was submitted.
        /// </value>
        public DateTime ResponseDate { get; set; }

        /// <summary>
        /// Gets or sets the response text.
        /// </summary>
        /// <value>
        /// The text contents of the response.
        /// </value>
        public string ResponseText { get; set; }
    }
}