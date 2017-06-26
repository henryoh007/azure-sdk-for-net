// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// FirewallRulesOperations operations.
    /// </summary>
    public partial interface IFirewallRulesOperations
    {
        /// <summary>
        /// Creates or updates the specified firewall rule. During update, the
        /// firewall rule with the specified name will be replaced with this
        /// new firewall rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to add or replace the
        /// firewall rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update the firewall rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FirewallRule>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string firewallRuleName, FirewallRule parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to which to update the
        /// firewall rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to update the firewall rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FirewallRule>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string firewallRuleName, UpdateFirewallRuleParameters parameters = default(UpdateFirewallRuleParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified firewall rule from the specified Data Lake
        /// Store account
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to delete the
        /// firewall rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string firewallRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to get the
        /// firewall rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<FirewallRule>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string firewallRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store firewall rules within the specified Data
        /// Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to get the
        /// firewall rules.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<FirewallRule>>> ListByAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store firewall rules within the specified Data
        /// Lake Store account.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<FirewallRule>>> ListByAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
