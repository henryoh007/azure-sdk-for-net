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
    /// A WebHDFS exception thrown indicating that the request is being
    /// throttled. Reducing the number of requests or request size helps to
    /// mitigate this error.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ThrottledException")]
    public partial class AdlsThrottledException : AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsThrottledException class.
        /// </summary>
        public AdlsThrottledException() { }

        /// <summary>
        /// Initializes a new instance of the AdlsThrottledException class.
        /// </summary>
        /// <param name="javaClassName">the full class package name for the
        /// exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.</param>
        /// <param name="message">the message associated with the exception
        /// that was thrown, such as 'Invalid value for webhdfs parameter
        /// "permission":...'.</param>
        public AdlsThrottledException(string javaClassName = default(string), string message = default(string))
            : base(javaClassName, message)
        {
        }

    }
}
