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

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing a collection of <see cref="MarketplaceApprovalRequestResource" /> and their operations.
    /// Each <see cref="MarketplaceApprovalRequestResource" /> in the collection will belong to the same instance of <see cref="PrivateStoreResource" />.
    /// To get a <see cref="MarketplaceApprovalRequestCollection" /> instance call the GetMarketplaceApprovalRequests method from an instance of <see cref="PrivateStoreResource" />.
    /// </summary>
    public partial class MarketplaceApprovalRequestCollection : ArmCollection, IEnumerable<MarketplaceApprovalRequestResource>, IAsyncEnumerable<MarketplaceApprovalRequestResource>
    {
        private readonly ClientDiagnostics _marketplaceApprovalRequestPrivateStoreClientDiagnostics;
        private readonly PrivateStoreRestOperations _marketplaceApprovalRequestPrivateStoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceApprovalRequestCollection"/> class for mocking. </summary>
        protected MarketplaceApprovalRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceApprovalRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MarketplaceApprovalRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceApprovalRequestPrivateStoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", MarketplaceApprovalRequestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MarketplaceApprovalRequestResource.ResourceType, out string marketplaceApprovalRequestPrivateStoreApiVersion);
            _marketplaceApprovalRequestPrivateStoreRestClient = new PrivateStoreRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceApprovalRequestPrivateStoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create approval request
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}
        /// Operation Id: PrivateStore_CreateApprovalRequest
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="requestApprovalId"> The request approval ID to get create or update. </param>
        /// <param name="data"> The MarketplaceApprovalRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestApprovalId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MarketplaceApprovalRequestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string requestApprovalId, MarketplaceApprovalRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestApprovalId, nameof(requestApprovalId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.CreateApprovalRequestAsync(Guid.Parse(Id.Name), requestApprovalId, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<MarketplaceApprovalRequestResource>(Response.FromValue(new MarketplaceApprovalRequestResource(Client, response), response.GetRawResponse()));
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
        /// Create approval request
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}
        /// Operation Id: PrivateStore_CreateApprovalRequest
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="requestApprovalId"> The request approval ID to get create or update. </param>
        /// <param name="data"> The MarketplaceApprovalRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestApprovalId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MarketplaceApprovalRequestResource> CreateOrUpdate(WaitUntil waitUntil, string requestApprovalId, MarketplaceApprovalRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestApprovalId, nameof(requestApprovalId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.CreateApprovalRequest(Guid.Parse(Id.Name), requestApprovalId, data, cancellationToken);
                var operation = new MarketplaceArmOperation<MarketplaceApprovalRequestResource>(Response.FromValue(new MarketplaceApprovalRequestResource(Client, response), response.GetRawResponse()));
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
        /// Get open request approval details
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}
        /// Operation Id: PrivateStore_GetRequestApproval
        /// </summary>
        /// <param name="requestApprovalId"> The request approval ID to get create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestApprovalId"/> is null. </exception>
        public virtual async Task<Response<MarketplaceApprovalRequestResource>> GetAsync(string requestApprovalId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestApprovalId, nameof(requestApprovalId));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.GetRequestApprovalAsync(Guid.Parse(Id.Name), requestApprovalId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceApprovalRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get open request approval details
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}
        /// Operation Id: PrivateStore_GetRequestApproval
        /// </summary>
        /// <param name="requestApprovalId"> The request approval ID to get create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestApprovalId"/> is null. </exception>
        public virtual Response<MarketplaceApprovalRequestResource> Get(string requestApprovalId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestApprovalId, nameof(requestApprovalId));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.GetRequestApproval(Guid.Parse(Id.Name), requestApprovalId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceApprovalRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all open approval requests of current user
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals
        /// Operation Id: PrivateStore_GetApprovalRequestsList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MarketplaceApprovalRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MarketplaceApprovalRequestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MarketplaceApprovalRequestResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _marketplaceApprovalRequestPrivateStoreRestClient.GetApprovalRequestsListAsync(Guid.Parse(Id.Name), cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MarketplaceApprovalRequestResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all open approval requests of current user
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals
        /// Operation Id: PrivateStore_GetApprovalRequestsList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MarketplaceApprovalRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MarketplaceApprovalRequestResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MarketplaceApprovalRequestResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _marketplaceApprovalRequestPrivateStoreRestClient.GetApprovalRequestsList(Guid.Parse(Id.Name), cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MarketplaceApprovalRequestResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}
        /// Operation Id: PrivateStore_GetRequestApproval
        /// </summary>
        /// <param name="requestApprovalId"> The request approval ID to get create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestApprovalId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string requestApprovalId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestApprovalId, nameof(requestApprovalId));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _marketplaceApprovalRequestPrivateStoreRestClient.GetRequestApprovalAsync(Guid.Parse(Id.Name), requestApprovalId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/requestApprovals/{requestApprovalId}
        /// Operation Id: PrivateStore_GetRequestApproval
        /// </summary>
        /// <param name="requestApprovalId"> The request approval ID to get create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="requestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="requestApprovalId"/> is null. </exception>
        public virtual Response<bool> Exists(string requestApprovalId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(requestApprovalId, nameof(requestApprovalId));

            using var scope = _marketplaceApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceApprovalRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = _marketplaceApprovalRequestPrivateStoreRestClient.GetRequestApproval(Guid.Parse(Id.Name), requestApprovalId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MarketplaceApprovalRequestResource> IEnumerable<MarketplaceApprovalRequestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MarketplaceApprovalRequestResource> IAsyncEnumerable<MarketplaceApprovalRequestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
