// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="DistributedAvailabilityGroupResource" /> and their operations.
    /// Each <see cref="DistributedAvailabilityGroupResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="DistributedAvailabilityGroupCollection" /> instance call the GetDistributedAvailabilityGroups method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class DistributedAvailabilityGroupCollection : ArmCollection, IEnumerable<DistributedAvailabilityGroupResource>, IAsyncEnumerable<DistributedAvailabilityGroupResource>
    {
        private readonly ClientDiagnostics _distributedAvailabilityGroupClientDiagnostics;
        private readonly DistributedAvailabilityGroupsRestOperations _distributedAvailabilityGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="DistributedAvailabilityGroupCollection"/> class for mocking. </summary>
        protected DistributedAvailabilityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DistributedAvailabilityGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DistributedAvailabilityGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _distributedAvailabilityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", DistributedAvailabilityGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DistributedAvailabilityGroupResource.ResourceType, out string distributedAvailabilityGroupApiVersion);
            _distributedAvailabilityGroupRestClient = new DistributedAvailabilityGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, distributedAvailabilityGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a distributed availability group between Sql On-Prem and Sql Managed Instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}
        /// Operation Id: DistributedAvailabilityGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="data"> The distributed availability group info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DistributedAvailabilityGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string distributedAvailabilityGroupName, DistributedAvailabilityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _distributedAvailabilityGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<DistributedAvailabilityGroupResource>(new DistributedAvailabilityGroupOperationSource(Client), _distributedAvailabilityGroupClientDiagnostics, Pipeline, _distributedAvailabilityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a distributed availability group between Sql On-Prem and Sql Managed Instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}
        /// Operation Id: DistributedAvailabilityGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="data"> The distributed availability group info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DistributedAvailabilityGroupResource> CreateOrUpdate(WaitUntil waitUntil, string distributedAvailabilityGroupName, DistributedAvailabilityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _distributedAvailabilityGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<DistributedAvailabilityGroupResource>(new DistributedAvailabilityGroupOperationSource(Client), _distributedAvailabilityGroupClientDiagnostics, Pipeline, _distributedAvailabilityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a distributed availability group info.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}
        /// Operation Id: DistributedAvailabilityGroups_Get
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual async Task<Response<DistributedAvailabilityGroupResource>> GetAsync(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _distributedAvailabilityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DistributedAvailabilityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a distributed availability group info.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}
        /// Operation Id: DistributedAvailabilityGroups_Get
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual Response<DistributedAvailabilityGroupResource> Get(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _distributedAvailabilityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DistributedAvailabilityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of a distributed availability groups in instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups
        /// Operation Id: DistributedAvailabilityGroups_ListByInstance
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DistributedAvailabilityGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DistributedAvailabilityGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DistributedAvailabilityGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _distributedAvailabilityGroupRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DistributedAvailabilityGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DistributedAvailabilityGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _distributedAvailabilityGroupRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DistributedAvailabilityGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of a distributed availability groups in instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups
        /// Operation Id: DistributedAvailabilityGroups_ListByInstance
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DistributedAvailabilityGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DistributedAvailabilityGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DistributedAvailabilityGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _distributedAvailabilityGroupRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DistributedAvailabilityGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DistributedAvailabilityGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _distributedAvailabilityGroupRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DistributedAvailabilityGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}
        /// Operation Id: DistributedAvailabilityGroups_Get
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _distributedAvailabilityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/distributedAvailabilityGroups/{distributedAvailabilityGroupName}
        /// Operation Id: DistributedAvailabilityGroups_Get
        /// </summary>
        /// <param name="distributedAvailabilityGroupName"> The distributed availability group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="distributedAvailabilityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="distributedAvailabilityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string distributedAvailabilityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(distributedAvailabilityGroupName, nameof(distributedAvailabilityGroupName));

            using var scope = _distributedAvailabilityGroupClientDiagnostics.CreateScope("DistributedAvailabilityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _distributedAvailabilityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, distributedAvailabilityGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DistributedAvailabilityGroupResource> IEnumerable<DistributedAvailabilityGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DistributedAvailabilityGroupResource> IAsyncEnumerable<DistributedAvailabilityGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
