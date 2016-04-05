using System.Diagnostics.CodeAnalysis;

namespace Sparkiy.WindowsStore.Analytics.Client.Models.v10
{
    /// <summary>
    /// The application rating.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AppRating : AppAnalyticsItem
    {
        /// <summary>
        /// Gets or sets the is revised.
        /// </summary>
        /// <value>
        /// The value true indicates that the rating was revised; otherwise false.
        /// </value>
        public string IsRevised { get; set; }

        /// <summary>
        /// Gets or sets the one star.
        /// </summary>
        /// <value>
        /// The number of one-star ratings.
        /// </value>
        public int OneStar { get; set; }

        /// <summary>
        /// Gets or sets the two stars.
        /// </summary>
        /// <value>
        /// The number of two-star ratings.
        /// </value>
        public int TwoStars { get; set; }

        /// <summary>
        /// Gets or sets the three stars.
        /// </summary>
        /// <value>
        /// The number of three-star ratings.
        /// </value>
        public int ThreeStars { get; set; }

        /// <summary>
        /// Gets or sets the four stars.
        /// </summary>
        /// <value>
        /// The number of four-star ratings.
        /// </value>
        public int FourStars { get; set; }

        /// <summary>
        /// Gets or sets the five stars.
        /// </summary>
        /// <value>
        /// The number of five-star ratings.
        /// </value>
        public int FiveStars { get; set; }
    }
}