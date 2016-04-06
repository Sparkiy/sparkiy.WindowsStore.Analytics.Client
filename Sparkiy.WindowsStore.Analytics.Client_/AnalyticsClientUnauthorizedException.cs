using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Sparkiy.WindowsStore.Analytics.Client
{
    /// <summary>
    /// The analytics client unauthorized exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class AnalyticsClientUnauthorizedException : AnalyticsClientException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientUnauthorizedException"/> class.
        /// </summary>
        public AnalyticsClientUnauthorizedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientUnauthorizedException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AnalyticsClientUnauthorizedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientUnauthorizedException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public AnalyticsClientUnauthorizedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientUnauthorizedException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected AnalyticsClientUnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}