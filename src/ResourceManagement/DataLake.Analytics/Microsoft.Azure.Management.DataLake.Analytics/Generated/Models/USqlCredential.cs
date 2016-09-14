// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL credential item.
    /// </summary>
    public partial class USqlCredential : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlCredential class.
        /// </summary>
        public USqlCredential() { }

        /// <summary>
        /// Initializes a new instance of the USqlCredential class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="name">the name of the credential.</param>
        public USqlCredential(string computeAccountName = default(string), System.Guid? version = default(System.Guid?), string name = default(string))
            : base(computeAccountName, version)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "credentialName")]
        public string Name { get; set; }

    }
}
