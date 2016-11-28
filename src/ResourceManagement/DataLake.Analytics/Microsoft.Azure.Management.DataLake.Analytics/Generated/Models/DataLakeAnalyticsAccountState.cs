// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{

    /// <summary>
    /// Defines values for DataLakeAnalyticsAccountState.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataLakeAnalyticsAccountState
    {
        [System.Runtime.Serialization.EnumMember(Value = "Active")]
        Active,
        [System.Runtime.Serialization.EnumMember(Value = "Suspended")]
        Suspended
    }
}
