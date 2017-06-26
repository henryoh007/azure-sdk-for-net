// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Store file or directory Access Control List information.
    /// </summary>
    public partial class AclStatusResult
    {
        /// <summary>
        /// Initializes a new instance of the AclStatusResult class.
        /// </summary>
        public AclStatusResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AclStatusResult class.
        /// </summary>
        /// <param name="aclStatus">the AclStatus object for a given file or
        /// directory.</param>
        public AclStatusResult(AclStatus aclStatus = default(AclStatus))
        {
            AclStatus = aclStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the AclStatus object for a given file or directory.
        /// </summary>
        [JsonProperty(PropertyName = "AclStatus")]
        public AclStatus AclStatus { get; set; }

    }
}
