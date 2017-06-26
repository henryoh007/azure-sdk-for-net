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
    /// Data Lake Store filesystem exception based on the WebHDFS definition
    /// for RemoteExceptions. This is a WebHDFS 'catch all' exception
    /// </summary>
    public partial class AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsRemoteException class.
        /// </summary>
        public AdlsRemoteException()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdlsRemoteException class.
        /// </summary>
        /// <param name="javaClassName">the full class package name for the
        /// exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.</param>
        /// <param name="message">the message associated with the exception
        /// that was thrown, such as 'Invalid value for webhdfs parameter
        /// "permission":...'.</param>
        public AdlsRemoteException(string javaClassName = default(string), string message = default(string))
        {
            JavaClassName = javaClassName;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the full class package name for the exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.
        /// </summary>
        [JsonProperty(PropertyName = "javaClassName")]
        public string JavaClassName { get; private set; }

        /// <summary>
        /// Gets the message associated with the exception that was thrown,
        /// such as 'Invalid value for webhdfs parameter "permission":...'.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
