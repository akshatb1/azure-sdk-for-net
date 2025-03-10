// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Share
{
    // Data plane generated client.
    /// <summary> The ReceivedAssets service client. </summary>
    public partial class ReceivedAssetsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ReceivedAssetsClient for mocking. </summary>
        protected ReceivedAssetsClient()
        {
        }

        /// <summary> Initializes a new instance of ReceivedAssetsClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.purview.azure.com/share. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ReceivedAssetsClient(string endpoint, TokenCredential credential) : this(endpoint, credential, new PurviewShareClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ReceivedAssetsClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.purview.azure.com/share. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ReceivedAssetsClient(string endpoint, TokenCredential credential, PurviewShareClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PurviewShareClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> List source asset of a received share. </summary>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="skipToken"> The continuation token to list the next page. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/ReceivedAssetsClient.xml" path="doc/members/member[@name='GetReceivedAssetsAsync(String,String,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetReceivedAssetsAsync(string receivedShareName, string skipToken = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));

            return GetReceivedAssetsImplementationAsync("ReceivedAssetsClient.GetReceivedAssets", receivedShareName, skipToken, context);
        }

        private AsyncPageable<BinaryData> GetReceivedAssetsImplementationAsync(string diagnosticsScopeName, string receivedShareName, string skipToken, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetReceivedAssetsRequest(receivedShareName, skipToken, context)
                        : CreateGetReceivedAssetsNextPageRequest(nextLink, receivedShareName, skipToken, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List source asset of a received share. </summary>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="skipToken"> The continuation token to list the next page. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/ReceivedAssetsClient.xml" path="doc/members/member[@name='GetReceivedAssets(String,String,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetReceivedAssets(string receivedShareName, string skipToken = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));

            return GetReceivedAssetsImplementation("ReceivedAssetsClient.GetReceivedAssets", receivedShareName, skipToken, context);
        }

        private Pageable<BinaryData> GetReceivedAssetsImplementation(string diagnosticsScopeName, string receivedShareName, string skipToken, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetReceivedAssetsRequest(receivedShareName, skipToken, context)
                        : CreateGetReceivedAssetsNextPageRequest(nextLink, receivedShareName, skipToken, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetReceivedAssetsRequest(string receivedShareName, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/receivedShares/", false);
            uri.AppendPath(receivedShareName, true);
            uri.AppendPath("/receivedAssets", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetReceivedAssetsNextPageRequest(string nextLink, string receivedShareName, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
