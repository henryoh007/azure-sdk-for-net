// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// Description of a NotificationHub WnsCredential.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class WnsCredential
    {
        /// <summary>
        /// Initializes a new instance of the WnsCredential class.
        /// </summary>
        public WnsCredential() { }

        /// <summary>
        /// Initializes a new instance of the WnsCredential class.
        /// </summary>
        /// <param name="packageSid">The package ID for this
        /// credential.</param>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="windowsLiveEndpoint">The Windows Live
        /// endpoint.</param>
        public WnsCredential(string packageSid = default(string), string secretKey = default(string), string windowsLiveEndpoint = default(string))
        {
            PackageSid = packageSid;
            SecretKey = secretKey;
            WindowsLiveEndpoint = windowsLiveEndpoint;
        }

        /// <summary>
        /// Gets or sets the package ID for this credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.packageSid")]
        public string PackageSid { get; set; }

        /// <summary>
        /// Gets or sets the secret key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.secretKey")]
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or sets the Windows Live endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.windowsLiveEndpoint")]
        public string WindowsLiveEndpoint { get; set; }

    }
}
