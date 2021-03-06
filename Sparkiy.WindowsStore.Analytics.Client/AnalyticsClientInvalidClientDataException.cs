﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Sparkiy.WindowsStore.Analytics.Client
{
    /// <summary>
    /// The analytics client invalid client data exception.
    /// </summary>
    /// <remarks>
    /// To resolve this exception. Check your client identifier and client secret for errors.
    /// </remarks>
    /// <seealso cref="System.Exception" />
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class AnalyticsClientInvalidClientDataException : AnalyticsClientException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientInvalidClientDataException"/> class.
        /// </summary>
        public AnalyticsClientInvalidClientDataException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientInvalidClientDataException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AnalyticsClientInvalidClientDataException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClientInvalidClientDataException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public AnalyticsClientInvalidClientDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}