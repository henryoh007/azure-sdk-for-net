// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information gained from troubleshooting of specified resource.
    /// </summary>
    public partial class TroubleshootingDetails
    {
        /// <summary>
        /// Initializes a new instance of the TroubleshootingDetails class.
        /// </summary>
        public TroubleshootingDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TroubleshootingDetails class.
        /// </summary>
        /// <param name="id">The id of the get troubleshoot operation.</param>
        /// <param name="reasonType">Reason type of failure.</param>
        /// <param name="summary">A summary of troubleshooting.</param>
        /// <param name="detail">Details on troubleshooting results.</param>
        /// <param name="recommendedActions">List of recommended
        /// actions.</param>
        public TroubleshootingDetails(string id = default(string), string reasonType = default(string), string summary = default(string), string detail = default(string), IList<TroubleshootingRecommendedActions> recommendedActions = default(IList<TroubleshootingRecommendedActions>))
        {
            Id = id;
            ReasonType = reasonType;
            Summary = summary;
            Detail = detail;
            RecommendedActions = recommendedActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the get troubleshoot operation.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets reason type of failure.
        /// </summary>
        [JsonProperty(PropertyName = "reasonType")]
        public string ReasonType { get; set; }

        /// <summary>
        /// Gets or sets a summary of troubleshooting.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets details on troubleshooting results.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets list of recommended actions.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedActions")]
        public IList<TroubleshootingRecommendedActions> RecommendedActions { get; set; }

    }
}
