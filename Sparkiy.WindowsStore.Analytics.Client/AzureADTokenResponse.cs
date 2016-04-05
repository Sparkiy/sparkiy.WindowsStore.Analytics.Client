using System.Diagnostics;

namespace Sparkiy.WindowsStore.Analytics.Client
{
    /// <summary>
    /// The Azure AD token response.
    /// </summary>
    /// <remarks>
    /// Properties that are in response are listed here:
    /// https://msdn.microsoft.com/en-us/library/azure/dn645543.aspx
    /// </remarks>
    [DebuggerDisplay("{access_token}")]
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once ClassNeverInstantiated.Global
    internal sealed class AzureADTokenResponse
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The requested access token.The calling web service can use this token to authenticate to the receiving web service.
        /// </value>
        // ReSharper disable once InconsistentNaming
        public string access_token { get; set; }

        /// <summary>
        /// Gets or sets the token type.
        /// </summary>
        /// <value>
        /// Indicates the token type value. The only type that Azure AD supports is Bearer For more information about bearer tokens, see The OAuth 2.0 Authorization Framework: Bearer Token Usage (RFC 6750).
        /// </value>
        // ReSharper disable once InconsistentNaming
        public string token_type { get; set; }

        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        /// <value>
        /// How long the access token is valid (in seconds).
        /// </value>
        // ReSharper disable once InconsistentNaming
        public string expires_in { get; set; }

        /// <summary>
        /// Gets or sets the expires on.
        /// </summary>
        /// <value>
        /// The time when the access token expires. The date is represented as the number of seconds from
        /// 1970-01-01T0:0:0Z UTC until the expiration time.This value is used to determine the lifetime of cached tokens.
        /// </value>
        // ReSharper disable once InconsistentNaming
        public string expires_on { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        /// <value>
        /// The App ID URI of the receiving web service.
        /// </value>
        // ReSharper disable once InconsistentNaming
        public string resource { get; set; }


        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            // ReSharper disable once BaseObjectEqualsIsObjectEquals
            return base.Equals(obj);
        }

        /// <summary>
        /// Compares to another token response instance.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>Returns <c>True</c> if all fields in both instances are equal; <c>False</c> otherwise.</returns>
        private bool Equals(AzureADTokenResponse other)
        {
            return string.Equals(this.access_token, other.access_token) &&
                   string.Equals(this.token_type, other.token_type) && string.Equals(this.expires_in, other.expires_in) &&
                   string.Equals(this.expires_on, other.expires_on) && string.Equals(this.resource, other.resource);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.access_token?.GetHashCode() ?? 0;
                hashCode = (hashCode*397) ^ (this.token_type?.GetHashCode() ?? 0);
                hashCode = (hashCode*397) ^ (this.expires_in?.GetHashCode() ?? 0);
                hashCode = (hashCode*397) ^ (this.expires_on?.GetHashCode() ?? 0);
                hashCode = (hashCode*397) ^ (this.resource?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}