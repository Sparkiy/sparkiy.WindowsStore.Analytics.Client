using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Sparkiy.WindowsStore.Analytics.Client
{
    /// <summary>
    /// The analytics client invalid request data exception.
    /// </summary>
    /// <seealso cref="Sparkiy.WindowsStore.Analytics.Client.AnalyticsClientException" />
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class AnalyticsClientInvalidRequestDataException : AnalyticsClientException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientInvalidRequestDataException"/> class.
        /// </summary>
        public AnalyticsClientInvalidRequestDataException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientInvalidRequestDataException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AnalyticsClientInvalidRequestDataException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientInvalidRequestDataException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public AnalyticsClientInvalidRequestDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}