// <auto-generated/>
using Graph.Community.Item._api;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Graph.Community.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \{serverRelativeSiteUrl}
    /// </summary>
    public class WithServerRelativeSiteUrlItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The _api property</summary>
        public Graph.Community.Item._api._apiRequestBuilder _api
        {
            get => new Graph.Community.Item._api._apiRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Graph.Community.Item.WithServerRelativeSiteUrlItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServerRelativeSiteUrlItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{serverRelativeSiteUrl}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Graph.Community.Item.WithServerRelativeSiteUrlItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServerRelativeSiteUrlItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{serverRelativeSiteUrl}", rawUrl)
        {
        }
    }
}
