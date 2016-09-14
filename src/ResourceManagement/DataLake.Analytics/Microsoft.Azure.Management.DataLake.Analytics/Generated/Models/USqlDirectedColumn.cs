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
    /// A Data Lake Analytics catalog U-SQL directed column item.
    /// </summary>
    public partial class USqlDirectedColumn
    {
        /// <summary>
        /// Initializes a new instance of the USqlDirectedColumn class.
        /// </summary>
        public USqlDirectedColumn() { }

        /// <summary>
        /// Initializes a new instance of the USqlDirectedColumn class.
        /// </summary>
        /// <param name="name">the name of the index in the table.</param>
        /// <param name="descending">the switch indicating if the index is
        /// descending or not.</param>
        public USqlDirectedColumn(string name = default(string), bool? descending = default(bool?))
        {
            Name = name;
            Descending = descending;
        }

        /// <summary>
        /// Gets or sets the name of the index in the table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the switch indicating if the index is descending or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "descending")]
        public bool? Descending { get; set; }

    }
}
