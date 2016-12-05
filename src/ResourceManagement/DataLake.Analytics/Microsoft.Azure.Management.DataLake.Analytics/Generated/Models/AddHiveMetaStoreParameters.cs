// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using Rest;
    using Rest.Serialization;
    using System.Linq;

    /// <summary>
    /// Hive metastore add or update parameters.
    /// </summary>
    [JsonTransformation]
    public partial class AddHiveMetaStoreParameters
    {
        /// <summary>
        /// Initializes a new instance of the AddHiveMetaStoreParameters class.
        /// </summary>
        public AddHiveMetaStoreParameters() { }

        /// <summary>
        /// Initializes a new instance of the AddHiveMetaStoreParameters class.
        /// </summary>
        /// <param name="serverUri">Gets or sets URL of the server to connect
        /// to. For example: myserver.database.windows.net,
        /// myserver.cloudapp.net</param>
        /// <param name="databaseName">Gets or sets the name of the database to
        /// connect to.</param>
        /// <param name="runtimeVersion">Gets or sets the Hive version
        /// associated with the metastore. Format: 1.2.3.4</param>
        /// <param name="userName">Sets the user name for the
        /// connection.</param>
        /// <param name="password">Sets the password for the
        /// connection.</param>
        public AddHiveMetaStoreParameters(string serverUri, string databaseName, string runtimeVersion, string userName, string password)
        {
            ServerUri = serverUri;
            DatabaseName = databaseName;
            RuntimeVersion = runtimeVersion;
            UserName = userName;
            Password = password;
        }

        /// <summary>
        /// Gets or sets URL of the server to connect to. For example:
        /// myserver.database.windows.net, myserver.cloudapp.net
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverUri")]
        public string ServerUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the database to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the Hive version associated with the metastore.
        /// Format: 1.2.3.4
        /// </summary>
        [JsonProperty(PropertyName = "properties.runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets sets the user name for the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets sets the password for the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServerUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServerUri");
            }
            if (DatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseName");
            }
            if (RuntimeVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuntimeVersion");
            }
            if (UserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserName");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}



