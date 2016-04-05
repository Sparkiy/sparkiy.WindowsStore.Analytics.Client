using System;
using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The application analytics item.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class AppAnalyticsItem
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The first date in the date range for the acquisition data. 
        /// If the request specified a single day, this value is that date. 
        /// If the request specified a week, month, or other date range, 
        /// this value is the first date in that date range.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The product ID of the app for which you are retrieving acquisition data.
        /// </value>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        /// <value>
        /// The display name of the app.
        /// </value>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the market.
        /// </summary>
        /// <value>
        /// The ISO 3166 country code of the market where the acquisition occurred.
        /// </value>
        public string Market { get; set; }

        /// <summary>
        /// Gets or sets the OS version.
        /// </summary>
        /// <value>
        /// The OS version on which the acquisition occurred.
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - Windows Phone 7.5
        ///  - Windows Phone 8
        ///  - Windows Phone 8.1
        ///  - Windows Phone 10
        ///  - Windows 8
        ///  - Windows 8.1
        ///  - Windows 10
        ///  - Unknown
        /// 
        /// </remarks>
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of the device.
        /// </summary>
        /// <value>
        /// The type of device that completed the acquisition. 
        /// </value>
        /// <remarks>
        /// One of the following strings:
        /// 
        ///  - PC
        ///  - Tablet
        ///  - Phone
        ///  - IoT
        ///  - Wearable
        ///  - Server
        ///  - Collaborative
        ///  - Other
        /// 
        /// </remarks>
        public string DeviceType { get; set; }
    }
}