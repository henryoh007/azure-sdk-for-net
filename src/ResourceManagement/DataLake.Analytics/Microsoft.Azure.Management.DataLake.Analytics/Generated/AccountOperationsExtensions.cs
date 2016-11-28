// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for AccountOperations.
    /// </summary>
    public static partial class AccountOperationsExtensions
    {
            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within a
            /// specific resource group. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount> ListByResourceGroup(this IAccountOperations operations, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount>), string select = default(string), bool? count = default(bool?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).ListByResourceGroupAsync(resourceGroupName, odataQuery, select, count), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within a
            /// specific resource group. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount>> ListByResourceGroupAsync(this IAccountOperations operations, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount>), string select = default(string), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within the
            /// current subscription. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount> List(this IAccountOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount>), string select = default(string), bool? count = default(bool?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).ListAsync(odataQuery, select, count), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within the
            /// current subscription. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount>> ListAsync(this IAccountOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<DataLakeAnalyticsAccount>), string select = default(string), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets details of the specified Data Lake Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to retrieve.
            /// </param>
            public static DataLakeAnalyticsAccount Get(this IAccountOperations operations, string resourceGroupName, string accountName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).GetAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details of the specified Data Lake Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<DataLakeAnalyticsAccount> GetAsync(this IAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Begins the delete delete process for the Data Lake Analytics account
            /// object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to delete
            /// </param>
            public static void Delete(this IAccountOperations operations, string resourceGroupName, string accountName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).DeleteAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Begins the delete delete process for the Data Lake Analytics account
            /// object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Begins the delete delete process for the Data Lake Analytics account
            /// object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to delete
            /// </param>
            public static void BeginDelete(this IAccountOperations operations, string resourceGroupName, string accountName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).BeginDeleteAsync(resourceGroupName, accountName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Begins the delete delete process for the Data Lake Analytics account
            /// object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IAccountOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates the specified Data Lake Analytics account. This supplies the user
            /// with computation services for Data Lake Analytics workloads
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Analytics account operation.
            /// </param>
            public static DataLakeAnalyticsAccount Create(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccount parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).CreateAsync(resourceGroupName, name, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the specified Data Lake Analytics account. This supplies the user
            /// with computation services for Data Lake Analytics workloads
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Analytics account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<DataLakeAnalyticsAccount> CreateAsync(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccount parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the specified Data Lake Analytics account. This supplies the user
            /// with computation services for Data Lake Analytics workloads
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Analytics account operation.
            /// </param>
            public static DataLakeAnalyticsAccount BeginCreate(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccount parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).BeginCreateAsync(resourceGroupName, name, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the specified Data Lake Analytics account. This supplies the user
            /// with computation services for Data Lake Analytics workloads
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Analytics account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<DataLakeAnalyticsAccount> BeginCreateAsync(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccount parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the Data Lake Analytics account object specified by the
            /// accountName with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Analytics account operation.
            /// </param>
            public static DataLakeAnalyticsAccount Update(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccountUpdateParameters parameters = default(DataLakeAnalyticsAccountUpdateParameters))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).UpdateAsync(resourceGroupName, name, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Data Lake Analytics account object specified by the
            /// accountName with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Analytics account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<DataLakeAnalyticsAccount> UpdateAsync(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccountUpdateParameters parameters = default(DataLakeAnalyticsAccountUpdateParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the Data Lake Analytics account object specified by the
            /// accountName with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Analytics account operation.
            /// </param>
            public static DataLakeAnalyticsAccount BeginUpdate(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccountUpdateParameters parameters = default(DataLakeAnalyticsAccountUpdateParameters))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).BeginUpdateAsync(resourceGroupName, name, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Data Lake Analytics account object specified by the
            /// accountName with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Analytics
            /// account.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Analytics account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Analytics account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<DataLakeAnalyticsAccount> BeginUpdateAsync(this IAccountOperations operations, string resourceGroupName, string name, DataLakeAnalyticsAccountUpdateParameters parameters = default(DataLakeAnalyticsAccountUpdateParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within a
            /// specific resource group. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount> ListByResourceGroupNext(this IAccountOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within a
            /// specific resource group. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount>> ListByResourceGroupNextAsync(this IAccountOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within the
            /// current subscription. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount> ListNext(this IAccountOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAccountOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Data Lake Analytics accounts, if any, within the
            /// current subscription. This includes a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<DataLakeAnalyticsAccount>> ListNextAsync(this IAccountOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
