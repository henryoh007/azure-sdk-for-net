// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System.Linq;

    /// <summary>
    /// Data Lake Store filesystem file status information response.
    /// </summary>
    public partial class FileStatusResult
    {
        /// <summary>
        /// Initializes a new instance of the FileStatusResult class.
        /// </summary>
        public FileStatusResult() { }

        /// <summary>
        /// Initializes a new instance of the FileStatusResult class.
        /// </summary>
        /// <param name="fileStatus">the file status object associated with
        /// the specified path.</param>
        public FileStatusResult(FileStatusProperties fileStatus = default(FileStatusProperties))
        {
            FileStatus = fileStatus;
        }

        /// <summary>
        /// Gets the file status object associated with the specified path.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "FileStatus")]
        public FileStatusProperties FileStatus { get; private set; }

    }
}
